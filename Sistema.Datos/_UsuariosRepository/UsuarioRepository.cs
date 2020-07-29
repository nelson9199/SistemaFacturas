using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Sistema.Datos.Services;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos._UsuariosRepository
{
    public class UsuarioRepository : IUsuarioRepository<Usuario>
    {
        private readonly IMapperProvider mapperProvider;
        private readonly IProtector protector;
        private readonly ApplicationDbContext context;
        private IMapper mapper;

        public UsuarioRepository(IMapperProvider mapperProvider, IProtector protector, ApplicationDbContext context)
        {
            this.mapperProvider = mapperProvider;
            this.protector = protector;
            this.context = context;
            this.mapper = this.mapperProvider.GetMapper();
        }

        public async Task<string> Activar(int id)
        {
            string respuesta = string.Empty;

            try
            {

                var usuarioOn = await context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);

                if (usuarioOn == null)
                {
                    return respuesta = "No se encontró el usuario con el Id dado";
                }

                usuarioOn.Estado = true;

                var entrada = context.Attach(usuarioOn);

                entrada.Property(x => x.Estado).IsModified = true;

                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo activar al usuario";
            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }
            return respuesta;
        }

        public async Task<string> Actualizar(Usuario objActualizar)
        {
            string respuesta = string.Empty;

            try
            {
                var usuarioDb = await context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == objActualizar.UsuarioId);

                if (usuarioDb == null)
                {
                    return "No se encontró el usuario a actualizar";
                }

                var entrada = mapper.Map(objActualizar, usuarioDb);

                if (objActualizar.Clave != "")
                {
                    //gerar un salt random
                    var rng = RandomNumberGenerator.Create();
                    var saltBytes = new byte[32];
                    rng.GetBytes(saltBytes);
                    var saltText = Convert.ToBase64String(saltBytes);

                    //generar el password salteado y hasheado
                    var saltedAndHashedPassword = protector.SaltAndHashPassword(objActualizar.Clave, saltText);

                    entrada.Clave = saltedAndHashedPassword;
                    entrada.Salt = saltText;
                }

                context.Entry(entrada).State = EntityState.Modified;

                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<string> Desactivar(int id)
        {
            string respuesta = string.Empty;

            try
            {
                var usuariOf = await context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);

                if (usuariOf == null)
                {
                    return respuesta = "No se encontró el usuario con el Id dado";
                }

                usuariOf.Estado = false;

                var entrada = context.Attach(usuariOf);

                entrada.Property(x => x.Estado).IsModified = true;

                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo desactivar al usuario";
            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }
            return respuesta;
        }

        public async Task<string> Eliminar(int id)
        {
            string respuesta = string.Empty;

            try
            {
                var usuario = await context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);

                if (usuario == null)
                {
                    return respuesta = "No se encontró el usuario con el Id dado";
                }

                context.Entry(usuario).State = EntityState.Deleted;
                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo borrar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<bool> ExisteEmail(string email)
        {
            try
            {

                bool emailExiste = await context.Usuarios.AnyAsync(x => x.Email == email);

                return emailExiste;

            }
            catch (Exception ex)
            {

                throw ex;
            };
        }

        public async Task<bool> ExisteNumDocumento(string numDocumento)
        {
            try
            {

                bool extiste = await context.Usuarios.AnyAsync(x => x.NumeroDocumento == numDocumento);
                return extiste;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> Insertar(Usuario objInsertar)
        {
            string respuesta = string.Empty;

            try
            {
                //gerar un salt random
                var rng = RandomNumberGenerator.Create();
                var saltBytes = new byte[32];
                rng.GetBytes(saltBytes);
                var saltText = Convert.ToBase64String(saltBytes);

                //generar el password salteado y hasheado
                var saltedAndHashedPassword = protector.SaltAndHashPassword(objInsertar.Clave, saltText);

                objInsertar.Clave = saltedAndHashedPassword;
                objInsertar.Salt = saltText;

                context.Add(objInsertar);
                respuesta = await context.SaveChangesAsync() == 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
            }
            return respuesta;
        }

        public async Task<List<Usuario>> Listar()
        {
            try
            {
                return await context.Usuarios.Include(x => x.Rol).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> ValidarPassword(string email, string password)
        {
            try
            {
                var usuario = await context.Usuarios.FirstOrDefaultAsync(x => x.Email == email);

                var saltedhasedPassword = protector.SaltAndHashPassword(password, usuario.Salt);

                if (saltedhasedPassword == usuario.Clave)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return false;
        }
    }
}
