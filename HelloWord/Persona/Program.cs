using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {    
            PersonaVegetariana personavegetariana = new PersonaVegetariana();
            personavegetariana.CalcularEdad();
            personavegetariana.Comer();
            
            PersonaDiabetica personadiabetica = new PersonaDiabetica();
            personadiabetica.CalcularEdad();
            personadiabetica.Comer();

            Console.Read();
        }

      
    }
}
