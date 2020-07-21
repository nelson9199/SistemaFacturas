using Sistema.Datos.ClienteRepository;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema.Negocio.ClienteLogic
{
    public class NCliente : IClienteAccesRepo<Cliente>
    {
        private readonly IClienteRepository<Cliente> clienteRepository;

        public NCliente(IClienteRepository<Cliente> clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public async Task<string> Activar(int id)
        {
            return await clienteRepository.Activar(id);
        }

        public async Task<string> Actualizar(Cliente objActualizar, string numDocAnt, string rucAnt)
        {
            if ((numDocAnt.Equals(objActualizar.NumeroDocumento) && !rucAnt.Equals(objActualizar.RUC)) ||
                (!numDocAnt.Equals(objActualizar.NumeroDocumento) && rucAnt.Equals(objActualizar.RUC)) ||
                (numDocAnt.Equals(objActualizar.NumeroDocumento) && rucAnt.Equals(objActualizar.RUC)))
            {

                return await clienteRepository.Actualizar(objActualizar);
            }
            else
            {
                bool existeNumDoc = await clienteRepository.ExisteNumDocumento(objActualizar.NumeroDocumento);
                bool exsiteRuc = await clienteRepository.ExisteRUC(objActualizar.RUC);

                if (existeNumDoc == true)
                {
                    return "Ya existe un cliente con el mismo número de documento de identificacion";
                }
                if (exsiteRuc == true)
                {
                    return "Ya existe un cliente con el mismo número de RUC";
                }

                return await clienteRepository.Actualizar(objActualizar);
            }

        }

        public async Task<string> Desactivar(int id)
        {

            return await clienteRepository.Desactivar(id);
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
