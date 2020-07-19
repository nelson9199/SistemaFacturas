using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Services;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.Repositories
{
    public class ClienteRepository : ICrud<Cliente>
    {
        private readonly IMapperProvider mapperProvider;
        private IMapper mapper;

        public ClienteRepository(IMapperProvider mapperProvider)
        {
            this.mapperProvider = mapperProvider;
            mapper = mapperProvider.GetMapper();
        }

        public async Task<string> Actualizar(Cliente objActualizar)
        {
            string respuesta = string.Empty;

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var clienteDb = await context.Clientes.FirstOrDefaultAsync(x => x.ClienteId == objActualizar.ClienteId);

                    if (clienteDb == null)
                    {
                        return "No se encontró el cliente a actualizar";
                    }

                    var entrada = mapper.Map(objActualizar, clienteDb);

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
                    var existe = await context.Clientes.AnyAsync(x => x.ClienteId == id);

                    if (!existe)
                    {
                        return respuesta = "No se encontró el cliente";
                    }

                    context.Remove(new Cliente() { ClienteId = id });
                    respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo borrar el registro";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<string> Insertar(Cliente objInsertar)
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

        public async Task<List<Cliente>> Listar()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Clientes.ToListAsync();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> ExisteNumDocumento(string numDocumento)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    bool extiste = await context.Clientes.AnyAsync(x => x.NumeroDocumento == numDocumento);
                    return extiste;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> ExisteRUC(string ruc)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    bool extiste = await context.Clientes.AnyAsync(x => x.RUC == ruc);
                    return extiste;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
