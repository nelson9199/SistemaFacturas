using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio.RolLogic
{
    public interface IRolAccessRepo
    {
        Task<List<Rol>> Listar();
    }
}
