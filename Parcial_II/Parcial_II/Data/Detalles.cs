using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    public class Detalles
    {
        public Detalles() { }
        public Detalles(string Fecha, string Tiempo, int RecursoId, Recursos Recurso, int TareaId, Tareas Tarea)
        {
            this.Fecha = Fecha;
            this.Tiempo = Tiempo;
            this.RecursoId = RecursoId;
            this.Recurso = Recurso;
            this.TareaId = TareaId;
            this.Tarea = Tarea;

        }
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }
        public int RecursoId { get; set; }
        public Recursos Recurso { get; set; }
        public int TareaId { get; set; }
        public Tareas Tarea { get; set; }
    }
}
