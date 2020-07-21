using Sistema.Datos.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.ClienteRepository
{
    public interface IClienteRepository<T> : ICrud<T>, IEstadoOnOfD
    {
        Task<bool> ExisteNumDocumento(string numDocumento);
        Task<bool> ExisteRUC(string ruc);
    }
}
