using Microsoft.EntityFrameworkCore;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Datos.ClenteFacturaRepository
{
    public class ClienteFacturaRepository : IClienteFacturaRepository
    {
        public async Task<string> Insertar(ClienteFacturas objInsertar)
        {
            string respuesta = string.Empty;

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Add(objInsertar);
                    respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo ingresar el registro en Cliente Facturas";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<List<ClienteFacturas>> Listar(int clienteId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.ClienteFacturas.Where(x => x.ClienteId == clienteId)
                        .Include(x => x.Factura).ToListAsync();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
