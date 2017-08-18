using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();
            animal.name = "Animal";

            Dog dog = new Dog(3);
            dog.Speak();
            dog.Name = "Dog";
            dog.Name = "New Dog";
            int numberOfSteps = dog.Run(4);

            bool isAWinner = false;

            do
            {
                int suma = 0;
                suma += numberOfSteps;
                if (suma >= 10)
                {
                    isAWinner = true;
                    Console.WriteLine("Dog is winner");
                }
                else
                {
                    Console.WriteLine("No terminó la carrera");
                }
            } while (isAWinner);

            Console.WriteLine("Dog name= " + dog.Name);
            //Console.WriteLine("Animal name= " + animal.name);

            Cat cat = new Cat(3);
            cat.Speak();
            cat.Name = "New Cat";
            int numberOfSteps2 = cat.Run(4);

            bool isAWinner2 = false;

            do
            {
                int suma2 = 0;
                suma2 +=  numberOfSteps;
                if (suma2>=10)
                {
                    isAWinner2 = true;
                    Console.WriteLine("Cat is winner");
                }
                else
                {
                    Console.WriteLine("No terminó la carrera");
                }
            } while (isAWinner2);
            

            //10
            Console.WriteLine("Cat name= "+cat.Name);
           // Console.WriteLine("Animal name= "+animal.name);

            Duck duck = new Animals.Duck(3);
            duck.Speak();
            duck.Name = "New Duck";
            int numberOfSteps3 = duck.Run(4);
            bool isAWinner3 = false;

            do
            {
                int suma3 = 0;
                suma3 += numberOfSteps2;
                if (suma3 >= 10)
                {
                    isAWinner3 = true;
                    Console.WriteLine("Duck winner");
                }
                else
                {
                    Console.WriteLine("No terminó la carrera");
                }
            } while (isAWinner3);
            Console.WriteLine("Duck name= " + duck.Name);
            //Console.WriteLine("Animal name= " + animal.name);

            




            //Animal dog2 = new Dog();
            //dog2.Speak();


            //List<Animal> VetList = new List<Animal>();

            //VetList.Add(new Cat());
            //VetList.Add(new Dog());
            //VetList.Add(new Duck());

            //foreach (Animal animal in VetList)
            //{
            //    animal.Speak();
            //}
            Console.ReadLine();
        }
    }
}
