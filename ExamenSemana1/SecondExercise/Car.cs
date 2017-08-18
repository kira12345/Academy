using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise
{
    public class Car : Vehicle
    {
        public int Doors { get; set; }

        public override void Move()
        {
            Console.WriteLine("Cars moves by gasoline power");
        }
    }
}
