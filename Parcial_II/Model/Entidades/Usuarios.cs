using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class Usuarios
    {
        public Usuarios() { }
        public Usuarios(string Usuario, string Clave)
        {
            this.Usuario = Usuario;
            this.Clave = Clave;

        }
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
