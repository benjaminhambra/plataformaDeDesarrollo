using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    public class UsuariosService
    {
        private TareasDbContext context;
        public UsuariosService(TareasDbContext _context)
        {
            context = _context;
        }
        public async Task<List<Usuarios>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }
        public async Task<Usuarios> GetById(int Id)
        {
            return await context.Usuarios.Where(i => i.Id == Id).SingleAsync();
        }
        public async Task<Usuarios> Save(Usuarios value)
        {
            if (value.Id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
