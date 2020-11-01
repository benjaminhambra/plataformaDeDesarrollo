using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    public class RecursosService
    {
        public Recursos[] GetRecursos()
        {
            Recursos[] resultado = new Recursos[4];
            resultado[0] = new Recursos();
            resultado[1] = new Recursos();
            resultado[2] = new Recursos();
            resultado[3] = new Recursos();

            return resultado;
        }
    }
}
