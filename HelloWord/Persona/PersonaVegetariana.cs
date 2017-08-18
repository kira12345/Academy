using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class PersonaVegetariana : Persona
    {        
        public void CalcularEdad()
        {
            Console.WriteLine("Calcular Edad");
            Console.WriteLine("Año de nacimiento");
            int año = int.Parse(Console.ReadLine());
            int actualAnio = DateTime.Now.Year;
            int edad = actualAnio - año;
            Console.WriteLine("Edad" + edad);
        }

        public override void Comer()
        {
            Console.WriteLine("Eres vegetariano");
        }
    }
}
