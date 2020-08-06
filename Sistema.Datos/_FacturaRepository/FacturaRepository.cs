using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Services;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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

                respuesta = await context.SaveChangesAsync() > 0 ? "OK" : "No se pudo actualizar el registro";

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
                var factura = await context.Facturas.FirstOrDefaultAsync(x => x.FacturaId == id);

                if (factura == null)
                {
                    return respuesta = "No se encontró la factura con el Id dado";
                }

                context.Entry(factura).State = EntityState.Deleted;
                respuesta = await context.SaveChangesAsync() > 0 ? "OK" : "No se pudo borrar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<bool> ExisteNumeroFactura(string numFactura, int idCliente)
        {
            try
            {
                var clienteFacturas = await context.ClienteFacturas.Include(x => x.Factura).Where(x => x.ClienteId == idCliente).ToListAsync();

                var facturas = clienteFacturas.Select(x => x.Factura).ToList();

                foreach (var item in clienteFacturas)
                {
                    foreach (var factura in facturas)
                    {
                        if (item.ClienteId == idCliente && factura.NumeroFactura == numFactura)
                        {
                            return true;
                        }
                    }
                }

                return false;
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
                respuesta = await context.SaveChangesAsync() > 0 ? "OK" : "No se pudo ingresar el registro";

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

        public async Task<Factura> ObtenerFacturaPorId(int id)
        {
            try
            {
                return await context.Facturas.FirstOrDefaultAsync(x => x.FacturaId == id);
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
