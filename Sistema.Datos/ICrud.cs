using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public interface ICrud<T>
    {
        Task<List<T>> Listar();
        Task<string> Insertar(T objInsertar);
        Task<string> Actualizar(T objActualizar);
        Task<string> Eliminar(int id);
    }
}
