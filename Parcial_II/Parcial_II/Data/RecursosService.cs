using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    public class RecursosService
    {
        private TareasDbContext context;
        public RecursosService(TareasDbContext _context)
        {
            context = _context;
        }
        public async Task<List<Recursos>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetRecursos();
        }
        public async Task<Recursos> GetById(int id)
        {
            return await context.Recursos.Where(i => i.Id == id).SingleAsync();
        }
        public async Task<Recursos> Save(Recursos value)
        {
            if (value.Id == 0)
            {
                await context.Recursos.AddAsync(value);
            }
            else
            {
                context.Recursos.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recursos.Where(i => i.Id == id).SingleAsync();
            context.Recursos.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            return await context.Usuarios.ToListAsync();
        }
    }
}
