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
            bool exsiteUsername = await usuarioRepository.ExisteUsername(objActualizar.Username);

            if (numDocuAnt.Equals(objActualizar.NumeroDocumento) && emailAnt.Equals(objActualizar.Username))
            {
                return await usuarioRepository.Actualizar(objActualizar);
            }
            if (!numDocuAnt.Equals(objActualizar.NumeroDocumento) && emailAnt.Equals(objActualizar.Username))
            {
                if (existeNumDoc == true)
                {
                    return "Ya existe un usuario con el mismo número de documento de identificacion";
                }
                return await usuarioRepository.Actualizar(objActualizar);
            }
            if (numDocuAnt.Equals(objActualizar.NumeroDocumento) && !emailAnt.Equals(objActualizar.Username))
            {
                if (exsiteUsername == true)
                {
                    return "Ya existe un usuario con el mismo nombre de usuario registrado. Porfavor ingrese otro nombre";
                }
                return await usuarioRepository.Actualizar(objActualizar);
            }

            if (existeNumDoc == true)
            {
                return "Ya existe un usuario con el mismo número de documento de identificacion";
            }
            if (exsiteUsername == true)
            {
                return "Ya existe un usuario con el mismo nombre de usuario registrado. Porfavor ingrese otro nombre";
            }
            return await usuarioRepository.Actualizar(objActualizar);
        }

        public async Task<string> Desactivar(int id, string nombreRol)
        {
            bool quedaUnUnicoAdmi = await usuarioRepository.ExisteUnUnicoAdmin();

            if (quedaUnUnicoAdmi == true)
            {
                if (nombreRol == "Usuario Común")
                {
                    return await usuarioRepository.Desactivar(id);
                }
                else
                {
                    return "No se puede desactivar el único Usuario Administrador que queda en el Sistema";
                }
            }
            else
            {
                return await usuarioRepository.Desactivar(id);
            }
        }

        public async Task<string> Eliminar(int id, string nombreRol)
        {
            bool quedaUnUnicoAdmi = await usuarioRepository.ExisteUnUnicoAdmin();

            if (quedaUnUnicoAdmi == true)
            {
                if (nombreRol == "Usuario Común")
                {
                    return await usuarioRepository.Eliminar(id);
                }
                else
                {
                    return "No se puede eliminar el único Usuario Administrador que queda en el Sistema";
                }
            }
            else
            {
                return await usuarioRepository.Eliminar(id);
            }
        }

        public async Task<string> Insertar(Usuario objInsertar)
        {
            bool existeNumDoc = await usuarioRepository.ExisteNumDocumento(objInsertar.NumeroDocumento);
            bool exsiteUsername = await usuarioRepository.ExisteUsername(objInsertar.Username);

            if (existeNumDoc == true)
            {
                return "Ya existe un usuario con el mismo número de documento de identificacion";
            }
            if (exsiteUsername == true)
            {
                return "Ya existe un usuario con el mismo nombre de usuario registrado. Porfavor ingrese otro nombre";
            }
            return await usuarioRepository.Insertar(objInsertar);
        }

        public async Task<List<Usuario>> Listar()
        {
            return await usuarioRepository.Listar();
        }

        public async Task<(Usuario, string)> Login(string username, string password)
        {
            return await usuarioRepository.Login(username, password);
        }
    }
}
