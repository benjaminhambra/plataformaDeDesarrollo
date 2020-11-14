using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class Recursos
    {
        public Recursos() { }
        public Recursos(string Nombre, Usuarios Usuario)
        {
            this.Nombre = Nombre;
            this.Usuario = Usuario;

        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
