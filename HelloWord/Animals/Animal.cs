using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {        
        public string name { get; set; } //Atributes
        public abstract int Run();
        public abstract string SetLanguage();
        public virtual void Speak()
        {
            Console.WriteLine("Hello");
        }
        public void Speak(string language)
        {
            Console.WriteLine("Hello");
        }
    }
}
