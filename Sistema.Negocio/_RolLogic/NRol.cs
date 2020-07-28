using Sistema.Datos.RolRepository;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.RolLogic
{
    public class NRol : IRolAccessRepo
    {
        private readonly IRolRepository rolRepository;

        public NRol(IRolRepository rolRepository)
        {
            this.rolRepository = rolRepository;
        }

        public async Task<List<Rol>> Listar()
        {
            return await rolRepository.Listar();
        }
    }
}
