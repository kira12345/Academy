using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise
{
    public class Program 
    {
        
        
        static void Main(string[] args)
        {
            GetTodaysDate();
            CreateSomeVehicles();
            SortMyVehicles();
            Console.ReadLine();
        }
        public static void GetTodaysDate()
        {
            string date = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine("Today is: " + date);
        }
        public static void CreateSomeVehicles()
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            vehicle.Move();
            car.Move();
            bicycle.Move();
            vehicle.Id=01;
            vehicle.HasEngine = true;
            vehicle.Name = "Vento";
            vehicle.Color = "Brown";
            car.Doors = 4;
            bicycle.Pedals = 2;

            ;        }

        public static void SortMyVehicles()
        {
            List<int> Vehicles = new List<int>();
            Random random = new Random();
            int numberrandom1 = random.Next(1, 10);
            
            Vehicles.Add(numberrandom1);

            foreach (var item in Vehicles)
            {
                Console.WriteLine("ID:" + numberrandom1);
            }
        }
    }
}
