using Sistema.Datos.Services;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.ClenteFacturaRepository
{
    public interface IClienteFacturaRepository
    {
        Task<List<ClienteFacturas>> Listar(int clienteId);
        Task<string> Insertar(ClienteFacturas objInsertar);
    }
}
