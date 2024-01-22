using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Users
{
    /// <summary>
    /// Perdonas es la clase padre donde hereda las caracteristicas principales  
    /// </summary>
    public class Departamento : Personas
    { 
        private string departament;

        public string Departament { get => departament; set => departament = value; }
    }
}
