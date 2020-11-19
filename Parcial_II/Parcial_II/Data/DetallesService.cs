using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Parcial_II.Data
{
    public class DetallesService
    {
        private TareasDbContext context;
        public DetallesService(TareasDbContext _context)
        {
            context = _context;
        }
        public async Task<List<Detalles>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetDetalles();
            //return await context.Detalles.Include(i=>i.Recurso).Include(i=>i.Tarea).ToListAsync();
        }
        public async Task<Detalles> GetById(int Id)
        {
            return await context.Detalles.Where(i => i.Id == Id).SingleAsync();
        }
        public async Task<Detalles> Save(Detalles value)
        {
            if (value.Id == 0)
            {
                await context.Detalles.AddAsync(value);
            }
            else
            {
                context.Detalles.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Detalles.Where(i => i.Id == id).SingleAsync();
            context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Recursos>> GetRecursos()
        {
            return await context.Recursos.ToListAsync();
        }
        public async Task<List<Tareas>> GetTareas()
        {
            return await context.Tareas.ToListAsync();
        }
    }
}
