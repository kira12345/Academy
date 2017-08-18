using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository studentrepository = new StudentRepository();
            Student student = new Student();
            var truefalse = studentrepository.Add("Kirama","aliyan",2017010000);
            
          
            if (truefalse==true)
            {
                Console.WriteLine("Added");
                //imprimir la lista
                //imprimir el primero de la lista por enrollment
                //borrar 
                var STUDENT = studentrepository.Get();
                foreach (var item in STUDENT)
                {
                    Console.WriteLine($"Id:{item.Id},Name:{ item.Name},Enrollment:{ item.Enrollment}, lastname:{item.lastname}");
                }

                studentrepository.AddCourse();

                studentrepository.Remove(2017010002);
            }
            else
            {
                Console.WriteLine("Error");
            }

            CourseRepository courserepository = new CourseRepository();
            Course course = new Course();

            var verdaderofalso = courserepository.Add("MATEMATICAS",3);
            if (verdaderofalso==true)
            {
                Console.WriteLine("Added");
                var COURSE = courserepository.Get();
                foreach (var item in COURSE)
                {
                    Console.WriteLine($"Id:{item},Name:{item},credits:{item}");
                }
                courserepository.Remove("POO");
            }
            Console.ReadLine();

            //Eliminar los cursos que tiene los estudiantes. 
            //los estudiantes agregan los cursos 

        }
    }
}
