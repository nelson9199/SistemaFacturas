using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.Services
{
    public interface IEstadoOnOfD
    {
        Task<string> Desactivar(int id);
        Task<string> Activar(int id);
    }
}
