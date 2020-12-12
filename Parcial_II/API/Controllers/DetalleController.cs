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
    public class DetalleController : ControllerBase
    {
        private Data.TareasDbContext context;
        public DetalleController(Data.TareasDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<List<Model.Entidades.Detalles>> GetAll()
        {
            return await context.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Model.Entidades.Detalles> GetById(int Id)
        {
            return await context.Detalles.Where(i => i.Id == Id).SingleAsync();
        }

        // [HttpPost]
        // public async Task<Model.Entidades.Detalles> Save(Model.Entidades.Detalles value)
        // {
        //     if (value.Id == 0)
        //     {
        //         await context.Detalles.AddAsync(value);
        //     }
        //     else
        //     {
        //         context.Detalles.Update(value);
        //     }
        //     await context.SaveChangesAsync();
        //     return value;
        // }

        [HttpPost]
        public IActionResult Post(Model.Entidades.Detalles valor)
        {
            var local = context.Detalles.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var detalle = await context.Detalles.FindAsync(id);
            if (detalle == null)
            {
                return NotFound();
            }

            context.Detalles.Remove(detalle);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
