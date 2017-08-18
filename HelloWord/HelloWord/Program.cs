using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //calcularEdad();
            //ConvertFtoc();
            //moverValores();
            //invertirLetras();
            //arregloLetras();
            //sumaCien();
            //conditionalif();
            //IfWithArray();
            //other();
            //explicacionTryCatch();
            tryedad();
        }

        public static void calcularEdad()
        {
            //Práctica 1
             Console.WriteLine("Introduce tu nombre");
             string name = Console.ReadLine();
             Console.WriteLine("En que año naciste?");
             int anio = int.Parse(Console.ReadLine());
             //Get the year
             int actualAnio = DateTime.Now.Year;

             int year = actualAnio - anio;

             Console.WriteLine("Hello, " + name + "!!!");
             Console.WriteLine("Tu edad es  "+ year);
             Console.Read();
        }
        public static void ConvertFtoc()
        {
            //Conversión 
            Console.WriteLine("Inserta los grados fahrenheit F° ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double grados = (fahrenheit - 32) / 1.8;

            Console.WriteLine("Son " + grados + "C°");
            Console.ReadLine();
        }

        public static void moverValores()
        {
            int valor = 10;
            int valor2 = 20;
            int auxiliar=0;

            Console.WriteLine("Valor A = " + valor);
            Console.WriteLine("Valor B = " + valor2);
            
            auxiliar = valor2;
            valor2 = valor;
            
            Console.WriteLine("Valor A ahora es " + auxiliar);
            Console.WriteLine("Valor B ahora es " + valor2);

            Console.ReadLine();
        }

        public static void invertirLetras()
        {
            char a;
            char b;
            char c;

            Console.WriteLine("Introduzca el primer caracter");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo caracter");
            b = char.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer caracter");
            c = char.Parse(Console.ReadLine());

            Console.WriteLine("\n"+c);
            Console.WriteLine(""+b);
            Console.WriteLine(""+a);

            Console.ReadLine();
        }

        public static void arraysExplicacion()
        {
            //const int numberOfStudents = 4;
            //int[] scores = new int[numberOfStudents];

            //int totalScore = 0;
            //foreach (int score in scores)
            //{
            //    totalScore += score;
            //}

            int[] scores = new int[5];
            int[] scores2 = { 2,3,6};

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("Score");
            for (int i = 0; i < 6; i++)
            {

            }
        }
        public static void arregloLetras()
        {
            char[] score = new char[3];

            Console.WriteLine("set char");
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
            for (int i = score.Length-1; i >= 0; i--)
            {
                Console.WriteLine(score[i]);
            }
            Array.Reverse(score);
            Console.ReadLine();
        }

        public static void sumaCien()
        {
            //int[] suma = new int[99];
            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
                Console.WriteLine(i);
                Console.WriteLine(""+suma);
            }
            Console.ReadLine();
        }

        public static void conditionalif()
        {
            int age = 0;
            Console.WriteLine("WHAT IS YOUR AGE?");
            age = int.Parse(Console.ReadLine());
            if (age>=18)
            {
                Console.WriteLine("YOU CAN DRINK");
            }
            else
            {
                Console.WriteLine("YOU CAN´T DRINK");
            }
            Console.ReadLine();
        }

        public static void IfWithArray()
        {
            int[]numbers = {34,56,0,19,90};
            Console.WriteLine("Input the number");
            int toFind = int.Parse(Console.ReadLine());
            bool aux = false;
            foreach (int num in numbers)
            {
                if (toFind == num)
                {
                    if (toFind ==num)
                    {
                        aux = true;
                        break;
                    }
                }
                if (aux)
                {
                    Console.WriteLine("It's here");
                }
                else
                {
                    Console.WriteLine("It isn't here");    
                }
            }
            Console.ReadLine();
        }
        public static void other()
        {
            Console.WriteLine("Set your string");
            string yourString = Console.ReadLine();

            if (yourString.Length == 0)
            {
                Console.WriteLine("Is empty");
            }
            else
            {
                if (yourString.Length > 5)
                {
                    string character = "character";
                    int position = character.IndexOf('a');
                    character=character.Remove(position, 1);
                    Console.WriteLine("Output word "+character);
                }
                else
                {
                    string home = "home";
                    int position = home.IndexOf('o');
                    home=home.Remove(position,1);
                    Console.WriteLine("Output word "+home);
                }
            }
            Console.ReadLine();   
        }
        public static void explicacionTryCatch()
        {
            int suma = 0;
            int[] array = { 2, 3, 1 };
            try
            {
                for (int x = 0; x < array.Length; x++)
                {
                    suma += array[x];
                }
                Console.WriteLine("La suma es: " + suma);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Index out of the range");
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End off the program");
            }
            Console.ReadLine();
        }
        public static void tryedad()
        {
            int age = 18;
            switch (age)
            {
                case 17:
                    Console.WriteLine("You are child");
                    break;
                case 18:
                    Console.WriteLine("really!!! you want a beer");
                    break;
                default:
                    Console.WriteLine("Go for a Coke");
                    break;
            }
            Console.ReadLine();
        }
    }
}
