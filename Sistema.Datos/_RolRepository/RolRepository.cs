using Microsoft.EntityFrameworkCore;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.RolRepository
{
    public class RolRepository : IRolRepository
    {
        public async Task<List<Rol>> Listar()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Roles.ToListAsync();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
