using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private Data.TareasDbContext context;
        public UsuarioController(Data.TareasDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<List<Model.Entidades.Usuarios>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Model.Entidades.Usuarios> GetById(int Id)
        {
            return await context.Usuarios.Where(i => i.Id == Id).SingleAsync();
        }

        [HttpPost]
        public async Task<Model.Entidades.Usuarios> Save(Model.Entidades.Usuarios value)
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
    }
}
