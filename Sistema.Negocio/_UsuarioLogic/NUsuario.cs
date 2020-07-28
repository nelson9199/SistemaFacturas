using Sistema.Datos._UsuariosRepository;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio._UsuarioLogic
{
    public class NUsuario : IUsuarioAccessRepo<Usuario>
    {
        private readonly IUsuarioRepository<Usuario> usuarioRepository;

        public NUsuario(IUsuarioRepository<Usuario> usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public async Task<string> Activar(int id)
        {
            return await usuarioRepository.Activar(id);
        }

        public async Task<string> Actualizar(Usuario objActualizar, string numDocuAnt, string emailAnt)
        {
            bool existeNumDoc = await usuarioRepository.ExisteNumDocumento(objActualizar.NumeroDocumento);
            bool exsiteEmail = await usuarioRepository.ExisteEmail(objActualizar.Email);

            if (numDocuAnt.Equals(objActualizar.NumeroDocumento) && emailAnt.Equals(objActualizar.Email))
            {
                return await usuarioRepository.Actualizar(objActualizar);
            }
            if (!numDocuAnt.Equals(objActualizar.NumeroDocumento) && emailAnt.Equals(objActualizar.Email))
            {
                if (existeNumDoc == true)
                {
                    return "Ya existe un usuario con el mismo número de documento de identificacion";
                }
                return await usuarioRepository.Actualizar(objActualizar);
            }
            if (numDocuAnt.Equals(objActualizar.NumeroDocumento) && !emailAnt.Equals(objActualizar.Email))
            {
                if (exsiteEmail == true)
                {
                    return "Ya existe un usuario con el mismo email registrado. Porfavor ingrese otro email";
                }
                return await usuarioRepository.Actualizar(objActualizar);
            }

            if (existeNumDoc == true)
            {
                return "Ya existe un usuario con el mismo número de documento de identificacion";
            }
            if (exsiteEmail == true)
            {
                return "Ya existe un usuario con el mismo email registrado. Porfavor ingrese otro email";
            }
            return await usuarioRepository.Actualizar(objActualizar);
        }

        public async Task<string> Desactivar(int id)
        {
            return await usuarioRepository.Desactivar(id);
        }

        public async Task<string> Eliminar(int id)
        {
            return await usuarioRepository.Eliminar(id);
        }

        public async Task<string> Insertar(Usuario objInsertar)
        {
            bool existeNumDoc = await usuarioRepository.ExisteNumDocumento(objInsertar.NumeroDocumento);
            bool exsiteEmail = await usuarioRepository.ExisteEmail(objInsertar.Email);

            if (existeNumDoc == true)
            {
                return "Ya existe un usuario con el mismo número de documento de identificacion";
            }
            if (exsiteEmail == true)
            {
                return "Ya existe un usuario con el mismo email registrado. Porfavor ingrese otro email";
            }
            return await usuarioRepository.Insertar(objInsertar);
        }

        public async Task<List<Usuario>> Listar()
        {
            return await usuarioRepository.Listar();
        }

        public async Task<bool> ValidarPassword(string email, string password)
        {
            return await usuarioRepository.ValidarPassword(email, password);
        }
    }
}
