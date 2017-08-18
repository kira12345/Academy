using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : IAnimals
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        private Random rdn = new Random(new System.DateTime().Millisecond);
        public Dog()
        {
            Speed = 4;
            Name = "Dog";
        }
        public Dog(int speed)
        {
            Speed = speed;
        }
        public void Run()
        {
            Console.WriteLine();
        }
        public int Run(int speed)
        {
            //1-4
            int steps = rdn.Next(1, speed);
            return steps;
        }
        public string Run(int speed, string name)
        {
            return "";
        }
        public void Speak()
        {
            Console.WriteLine("Wof");
        }
        
    }
}
