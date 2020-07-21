using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.Services
{
    public interface IEstadoOnOfN
    {
        Task<string> Desactivar(int id);
        Task<string> Activar(int id);
    }
}
