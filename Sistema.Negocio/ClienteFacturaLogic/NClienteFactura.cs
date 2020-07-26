using Sistema.Datos.ClenteFacturaRepository;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.ClienteFacturaLogic
{
    public class NClienteFactura : IClienteFacturaAccesRepo
    {
        private readonly IClienteFacturaRepository clienteFacturaRepository;

        public NClienteFactura(IClienteFacturaRepository clienteFacturaRepository)
        {
            this.clienteFacturaRepository = clienteFacturaRepository;
        }

        public async Task<string> Insertar(ClienteFacturas objInsertar)
        {
            return await clienteFacturaRepository.Insertar(objInsertar);
        }

        public async Task<List<ClienteFacturas>> Listar(int clienteId)
        {
            return await clienteFacturaRepository.Listar(clienteId);
        }
    }
}
