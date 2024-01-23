using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Users
{
    public class Bucles : Personas
    {
        private string pass;

        public string Pass { get => pass; set => pass = value; }

        public void acceso()
        {
            if (pass == "password_1")
                Console.WriteLine("si hay acceso");
            else
                Console.WriteLine("no tiene acceso");   
        }

        public void accessi ()
        {
            Console.WriteLine("bienvenidos a nuestro sistema");
        }
    }
}
