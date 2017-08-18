using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public abstract void Comer();
        public virtual void CalcularEdad()
        {
            Console.WriteLine("Calcular edad");
        }
        public void CalcularEdad(int CalcularEdad)
        {
            Console.WriteLine("Año de nacimiento");
            int año = int.Parse(Console.ReadLine());
            int actualAnio = DateTime.Now.Year;
            int edad = actualAnio - año;
            Console.WriteLine("Edad"+edad);
        }
    }
}
