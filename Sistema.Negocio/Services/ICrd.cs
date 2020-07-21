using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.Services
{
    public interface ICrd<T>
    {
        Task<List<T>> Listar();
        Task<string> Insertar(T objInsertar);
        Task<string> Eliminar(int id);
    }
}
