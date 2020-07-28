using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.RolRepository
{
    public interface IRolRepository
    {
        Task<List<Rol>> Listar();
    }
}
