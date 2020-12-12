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
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetRecursosById(id);
        }
        public async Task<Recursos> Save(Recursos value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.CreateRecurso(value);
        }

        public async Task<Recursos> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.DeleteRecurso(id);
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetUsuarios();
        }
    }
}
