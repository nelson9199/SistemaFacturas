using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.ClienteFacturaLogic
{
    public interface IClienteFacturaAccesRepo
    {
        Task<List<ClienteFacturas>> Listar(int clienteId);

        Task<string> Insertar(ClienteFacturas objInsertar);
    }
}
