using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {

        
        static void Main(string[] args)
        {

            var list1 = new List<int> { 3,7,1,9,10};
            var lista2 = new List<int> { 5,4,8,2,1,7};

            var listNames = new List<string> {"cero", "uno", "dos", "tres" };
            var listNumbers = new List<int> { 0,1, 2, 3 };

            var names = from x in listNumbers
                        select listNames[x];

            var names2 = listNames.Select(x => listNumbers);

            //Imprime el nombre de los números
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            

            //Regresa una lista con todos los elementos que sean menor que cinco
            var result = list1.Where(x => x < 5);
            
            //listas.AddRange(lista2);

            var AllElements = list1.Concat(lista2);

            var contains= list1.Contains(5);

            //Union
            //var union = listas.Union(lista2);

            //Intersección
            //
            var intersectar = list1.Intersect(lista2);

            var disitinc = list1.Distinct();

            var except = list1.Except(lista2);

            List<int> listA = new List<int>();
            List<int> listB = new List<int>();

            var v2 = from x in listA
                         where !listB.Contains(x)
                         select x;

            //foreach (var item in lista2)
            //{
            //    listas.Add(item);
            //}

            foreach (var item in list1)
            {
                Console.WriteLine(item); 
            }

            Console.ReadLine();
        }
    }
}
