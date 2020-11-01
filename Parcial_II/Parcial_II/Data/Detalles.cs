using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    public class Detalles
    {
        public Detalles() { }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public int IdRecurso { get; set; }
        public Recursos Recurso { get; set; }
        public int IdTarea { get; set; }
        public Tareas Tarea { get; set; }
    }
}
