using Sistema.Entidades;
using Sistema.Negocio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio._UsuarioLogic
{
    public interface IUsuarioAccessRepo<T>
    {
        Task<List<T>> Listar();
        Task<string> Insertar(T objInsertar);
        Task<string> Actualizar(T objActualizar, string numDocuAnt, string emailAnt);
        Task<string> Eliminar(int id, string nombreRol);
        Task<(T, string)> Login(string username, string password);
        Task<string> Desactivar(int id, string nombreRol);
        Task<string> Activar(int id);
    }
}
