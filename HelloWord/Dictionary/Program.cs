using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> States;
            //States = new Dictionary<string, string>();
            //States.Add("CA","Californa");
            //States.Add("WA","Washington");
            //States.Add("NY","New York");
            //Console.WriteLine(States);

            ///Nueva forma de instanciar e inserción de los tres elementos
            //var States = new Dictionary<string, string>()
            //{
            //    {"CA","California" },
            //    {"WA","Washington"},
            //    {"NY","New York"}
            //};
            //Console.WriteLine(States);
            VendorRepository vendorrepository = new VendorRepository();
            vendorrepository.RetrieveWithKeys();
            Console.ReadLine();

        }
    }
}
