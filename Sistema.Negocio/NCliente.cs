using Sistema.Datos.Repositories;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NCliente : ICrudN<Cliente>
    {
        private readonly ClienteRepository clienteRepository;

        public NCliente(ClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public Task<string> Actualizar(Cliente objActualizar, string numDocAnt, string rucAnt)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Eliminar(int id)
        {
            return await clienteRepository.Eliminar(id);
        }

        public async Task<string> Insertar(Cliente objInsertar)
        {
            bool existeNumDoc = await clienteRepository.ExisteNumDocumento(objInsertar.NumeroDocumento);
            bool exsiteRuc = await clienteRepository.ExisteRUC(objInsertar.RUC);

            if (existeNumDoc == true)
            {
                return "Ya existe un cliente con el mismo número de documento de identificacion";
            }
            if (exsiteRuc == true)
            {
                return "Ya existe un cliente con el mismo número de RUC";
            }
            return await clienteRepository.Insertar(objInsertar);
        }

        public async Task<List<Cliente>> Listar()
        {
            return await clienteRepository.Listar();
        }
    }
}
