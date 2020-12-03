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
    public class TareaController : ControllerBase
    {
        private Data.TareasDbContext context;
        public TareaController(Data.TareasDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<List<Model.Entidades.Tareas>> GetAll()
        {
            return await context.Tareas.Include(i => i.Recurso).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Model.Entidades.Tareas> GetById(int Id)
        {
            return await context.Tareas.Where(i => i.Id == Id).SingleAsync();
        }

        //[HttpPost]
        //public async Task<Model.Entidades.Tareas> Save(Model.Entidades.Tareas value){
        //    if (value.Id == 0)
        //    {
        //        await context.Tareas.AddAsync(value);
        //    }
        //    else
        //    {
        //        context.Tareas.Update(value);
        //    }
        //    await context.SaveChangesAsync();
        //    return value;
        //}

        [HttpPost]
        public IActionResult Post(Model.Entidades.Tareas valor)
        {
            var local = context.Tareas.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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
