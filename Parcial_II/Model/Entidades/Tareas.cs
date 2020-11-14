using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class Tareas
    {
        public Tareas() { }
        public Tareas(string Titulo, string Vencimiento, string Estimacion, Recursos Recurso, string Estado)
        {
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.Recurso = Recurso;
            this.Estado = Estado;

        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public string Estimacion { get; set; }
        public int RecursoId { get; set; }
        public Recursos Recurso { get; set; }
        public string Estado { get; set; }
    }
}