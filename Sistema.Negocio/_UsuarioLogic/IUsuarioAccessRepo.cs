using Sistema.Entidades;
using Sistema.Negocio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio._UsuarioLogic
{
    public interface IUsuarioAccessRepo<T> : IEstadoOnOfN
    {
        Task<List<object>> Listar();
        Task<string> Insertar(T objInsertar);
        Task<string> Actualizar(T objActualizar, string numDocuAnt, string emailAnt);
        Task<string> Eliminar(int id);
        Task<bool> ValidarPassword(string email, string password);
    }
}
