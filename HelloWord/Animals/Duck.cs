using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Duck : Animal 
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        private Random rdn = new Random(new System.DateTime().Millisecond);
        public Duck()
        {
            Speed = 4;
            Name = "Cat";
        }
        public Duck(int speed)
        {
            Speed = speed;
        }
        public void Run()
        {
            Console.WriteLine();
        }
        public int Run(int speed)
        {
            //Random rdn = new Random();
            //1-4
            int steps = rdn.Next(1, speed);
            return steps;
        }
        public string Run(int speed, string name)
        {
            return "";
        }
        //Overloading
        public override void Speak()
        {
            Console.WriteLine("Cuak");
        }
    }
}
