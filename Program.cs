using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Users
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL PROGRAMA DE SEGURIDAD DE LA FUERZAS ESPECIALIDADES\n");

            Personas persona = new Personas();
           // persona.Id = 1;
            persona.Name = "test";
            persona.Age = 30;
            persona.Number = 2526464;
            persona.Password = "password_1";
            persona.Email = "jmercally";

            Departamento departamento = new Departamento();
            departamento.Id = 2;
            departamento.Name = "peres ";
            departamento.Age = 25;
            departamento.Number = 45464;
            departamento.Password = "uljljo";
            departamento.Email = "karla";
            departamento.Departament = "cirugia";

            Bucles claims = new Bucles();
            claims.Name = "hola";
            claims.Age = 30;
            claims.Number = 456;
            claims.Pass = "pass";

            Console.WriteLine("SR(A) " + persona.Name + " \nUsted tiene " + persona.Age + " años de Edad " +
                "\n numero de telefono " + persona.Number + "\npassword: " + persona.Password + "\n Email " + persona.Email + "\n");

            Console.WriteLine("SR(A) " + departamento.Name + "\nUsted tiene " + departamento.Age + " años de Edad " +
               " y con el numero de telefono " + departamento.Number + "\npassword: " + departamento.Password + " y el Email " 
               + departamento.Email + " Departamento: " + departamento.Departament + "\n");

            Console.WriteLine($"El usuario {.Name} \n");
            claims.acceso();

            Console.ReadLine();
        }
    }
}
