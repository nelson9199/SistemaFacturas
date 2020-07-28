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
        private IMapper mapper = null;

        public FacturaRepository(IMapperProvider mapperProvider)
        {
            this.mapperProvider = mapperProvider;
            mapper = this.mapperProvider.GetMapper();
        }

        public async Task<string> Actualizar(Factura objActualizar)
        {
            string respuesta = string.Empty;

            try
            {
                using (var context = new ApplicationDbContext())
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
                using (var context = new ApplicationDbContext())
                {
                    var existe = await context.Facturas.AnyAsync(x => x.FacturaId == id);

                    if (!existe)
                    {
                        return respuesta = "No se encontró la factura con el Id dado";
                    }

                    context.Remove(new Factura() { FacturaId = id });
                    respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo borrar el registro";
                }
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
                using (var context = new ApplicationDbContext())
                {
                    bool extiste = await context.Facturas.AnyAsync(x => x.NumeroFactura == numFactura);
                    return extiste;
                }
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
                using (var context = new ApplicationDbContext())
                {
                    context.Add(objInsertar);
                    respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo ingresar el registro";
                }
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
                using (var context = new ApplicationDbContext())
                {
                    return await context.Facturas.ToListAsync();
                }
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

                using (var context = new ApplicationDbContext())
                {
                    return context.Facturas.AsEnumerable().ToList().Last();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
