using Sistema.Entidades;
using Sistema.Negocio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.ClienteLogic
{
    public interface IClienteAccesRepo<T> : ICrd<T>, IEstadoOnOfN
    {
        Task<string> Actualizar(Cliente objActualizar, string numDocAnt, string rucAnt);
    }
}
