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
        private readonly ApplicationDbContext context;

        public RolRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Rol>> Listar()
        {
            try
            {

                return await context.Roles.ToListAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
