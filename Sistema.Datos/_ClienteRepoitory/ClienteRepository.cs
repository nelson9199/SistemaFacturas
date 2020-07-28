using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Services;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.ClienteRepository
{
    public class ClienteRepository : IClienteRepository<Cliente>
    {
        private readonly IMapperProvider mapperProvider;
        private IMapper mapper;

        public ClienteRepository(IMapperProvider mapperProvider)
        {
            this.mapperProvider = mapperProvider;
            mapper = this.mapperProvider.GetMapper();
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
                        return respuesta = "No se encontró el cliente con el Id dado";
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

        public async Task<string> Activar(int id)
        {
            string respuesta = string.Empty;

            try
            {

                using (var context = new ApplicationDbContext())
                {
                    var clienteOn = await context.Clientes.FirstOrDefaultAsync(x => x.ClienteId == id);

                    if (clienteOn == null)
                    {
                        return respuesta = "No se encontró el cliente con el Id dado";
                    }

                    clienteOn.Estado = true;

                    var entrada = context.Attach(clienteOn);

                    entrada.Property(x => x.Estado).IsModified = true;

                    respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo activar al cliente";
                }
            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }
            return respuesta;
        }

        public async Task<string> Desactivar(int id)
        {
            string respuesta = string.Empty;

            try
            {

                using (var context = new ApplicationDbContext())
                {
                    var clienteOf = await context.Clientes.FirstOrDefaultAsync(x => x.ClienteId == id);

                    if (clienteOf == null)
                    {
                        return respuesta = "No se encontró el cliente con el Id dado";
                    }

                    clienteOf.Estado = false;

                    var entrada = context.Attach(clienteOf);

                    entrada.Property(x => x.Estado).IsModified = true;

                    respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo desactivar al cliente";
                }
            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }
            return respuesta;
        }
    }
}
