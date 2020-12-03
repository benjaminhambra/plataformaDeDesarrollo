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
        }
        public async Task<Detalles> GetById(int Id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetDetallesById(Id);
        }
        public async Task<Detalles> Save(Detalles value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.CreateDetalle(value);
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
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetRecursos();
        }
        public async Task<List<Tareas>> GetTareas()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetTareas();
        }
    }
}
