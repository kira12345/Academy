
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal, IAnimals
    {
        public int Speed { get; set;}
        public string Name { get; set;}
        private Random rdn = new Random(new System.DateTime().Millisecond);
        public Cat()
        {
            Speed = 4;
            Name = "Cat";
        }
        public Cat(int speed)
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
        public void Speak()
        {
            Console.WriteLine("Mew");
        }

        //public override int Run()
        //{
        //    throw new NotImplementedException();
        //}

        public override string SetLanguage()
        {
            throw new NotImplementedException();
        }

        public override int Run()
        {
            throw new NotImplementedException();
        }

        //public override int Run()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
