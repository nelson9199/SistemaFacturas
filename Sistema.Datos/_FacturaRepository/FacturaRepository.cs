using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Services;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.FacturaRepository
{
    public class FacturaRepository : IFacturaRepository<Factura>
    {
        private readonly IMapperProvider mapperProvider;
        private readonly ApplicationDbContext context;
        private IMapper mapper = null;

        public FacturaRepository(IMapperProvider mapperProvider, ApplicationDbContext context)
        {
            this.mapperProvider = mapperProvider;
            this.context = context;
            mapper = this.mapperProvider.GetMapper();
        }

        public async Task<string> Actualizar(Factura objActualizar)
        {
            string respuesta = string.Empty;

            try
            {

                var facturaDb = await context.Facturas.FirstOrDefaultAsync(x => x.FacturaId == objActualizar.FacturaId);

                if (facturaDb == null)
                {
                    return "No se encontró la factura a actualizar";
                }

                var entrada = mapper.Map(objActualizar, facturaDb);

                context.Entry(entrada).State = EntityState.Modified;

                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo actualizar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<string> Eliminar(int id)
        {
            string respuesta = string.Empty;

            try
            {
                var factura = await context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);

                if (factura == null)
                {
                    return respuesta = "No se encontró el usuario con el Id dado";
                }

                context.Entry(factura).State = EntityState.Deleted;
                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo borrar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<bool> ExisteCodigoFactura(string numFactura)
        {
            try
            {
                bool extiste = await context.Facturas.AnyAsync(x => x.NumeroFactura == numFactura);
                return extiste;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> Insertar(Factura objInsertar)
        {
            string respuesta = string.Empty;

            try
            {
                context.Add(objInsertar);
                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<List<Factura>> Listar()
        {
            try
            {
                return await context.Facturas.ToListAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Factura ObtenerIdUltimaFactura()
        {
            try
            {

                return context.Facturas.AsEnumerable().ToList().Last();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
