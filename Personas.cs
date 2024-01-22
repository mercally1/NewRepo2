using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Users
{
   
    public class Personas
    {
        private int id;
        private string name;//nombre de la persona.
        private int age;//edad de la percona.
        private int number;//numero de telefono de la persona.
        private string password;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Number { get => number; set => number = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public void Persona()
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Number = Number;   
            this.Password = Password;
            this.Email = Email;    
        }
    }
}
