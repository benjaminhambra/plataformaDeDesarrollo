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
    public class RecursoController : ControllerBase
    {
        private Data.TareasDbContext context;
        public RecursoController(Data.TareasDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<List<Model.Entidades.Recursos>> GetAll()
        {
            return await context.Recursos.Include(i => i.Usuario).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Model.Entidades.Recursos> GetById(int Id)
        {
            return await context.Recursos.Where(i => i.Id == Id).SingleAsync();
        }

        //[HttpPost]
        //public async Task<Model.Entidades.Recursos> Save(Model.Entidades.Recursos value)
        //{
        //    if (value.Id == 0)
        //    {
        //await context.Recursos.AddAsync(value);
        //}
        //    else
        //  {
        //context.Recursos.Update(value);
        // }
        //await context.SaveChangesAsync();
        //   return value;
        //}

        [HttpPost]
        public IActionResult Post(Model.Entidades.Recursos valor)
        {
            var local = context.Recursos.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if (local != null)
                context.Entry(local).State = EntityState.Detached;

            if (valor.Id == 0)
            {
                context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                context.Entry(valor).State = EntityState.Modified;
            }
            context.SaveChanges();
            return Ok(valor);
        }
    }
}
