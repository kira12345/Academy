using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSemana1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTodaysDate();
            Console.ReadLine();
        }

        public static void GetTodaysDate()
        {
            string date = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine("Today is: "+date);
        }
    }
}
