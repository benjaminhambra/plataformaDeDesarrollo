using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    public class Tareas
    {
        public Tareas() { }
        public Tareas(string Titulo, string Vencimiento, string Estimacion, /*Recursos Responsable, */string Estado)
        {
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            //this.Responsable = Responsable;
            this.Estado = Estado;

        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public string Estimacion { get; set; }
        public int IdRecurso { get; set; }
        //public Recursos Responsable { get; set; }
        public string Estado { get; set; }
    }
}