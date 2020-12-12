using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.IO;
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
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetUsuarios();
        }
        public async Task<Usuarios> GetById(int Id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.GetUsuariosById(Id);
            //return await context.Usuarios.Where(i => i.Id == Id).SingleAsync();
        }
        public async Task<Usuarios> Save(Usuarios value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
            return await remoteService.CreateUsuarios(value);
        }
        public async Task<Usuarios> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44362/api/");
                return await remoteService.DeleteUsuario(id);
        }
    }
}
