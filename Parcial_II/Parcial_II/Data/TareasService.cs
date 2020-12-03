using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    public class TareasService
    {
        private TareasDbContext context;
        public TareasService(TareasDbContext _context)
        {
            context = _context;
        }
        public async Task<List<Tareas>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetTareas();
        }
        public async Task<Tareas> GetById(int Id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetTareasById(Id);
        }
        public async Task<Tareas> Save(Tareas value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.CreateTarea(value);
        }
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tareas.Where(i => i.Id == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Recursos>> GetRecursos()
        {

            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetRecursos();
        }
    }
}
