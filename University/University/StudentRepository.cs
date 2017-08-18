using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace University
{
    public class StudentRepository
    {
        //public void Add(String Name, String lastName,int Enrollment)
        //{
        //    Student student = new Student();
        //}

        private DbEfUniversity dbefuniversity = new DbEfUniversity();
        public bool Add(string name, string lastName, int Enrollment)
        {
            try
            {
                var student = new Student { Name = name, lastname = lastName, Enrollment = Enrollment };
                dbefuniversity.Student.Add(student);
                dbefuniversity.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<Student> Get()
        {
            return dbefuniversity.Student.ToList();

        }

        public Student Get(int Enrollment)
        {
            return dbefuniversity.Student.Where(x => x.Enrollment == Enrollment)
                .First();
        }

        public void Remove(int Enrollment)
        {
            try
            {
                dbefuniversity.Student.Remove(Get(Enrollment));
                dbefuniversity.SaveChanges();

                Console.WriteLine("Se eliminó con éxito el elemento");
            }
            catch (Exception e)
            {
                Console.WriteLine("No se eliminó el elemento");
            }
            //dbefuniversity.Student.Remove();
            //var finded = dbefuniversity.Student.Find(first);

            dbefuniversity.SaveChanges();
        }

        public List<Course> GetCourse()
        {
            return dbefuniversity.Course.ToList();
        }

        public Course GetCourse(string name)
        {
            return dbefuniversity.Course.Where(x => x.Name == name)
                .First();
        }

        public void RemoveCourses(string name)
        {
            try
            {
                
                //Eliminar el curso al estudiante
                dbefuniversity.Course.Remove(GetCourse(name));
                dbefuniversity.SaveChanges();

                Console.WriteLine("Se eliminó con éxito");
            }
            catch (Exception e)
            {
                Console.WriteLine("No se eliminó");
            }
        }

        public void AddCourse()
        {
            var s = dbefuniversity.Student.Find(1);
            var c = dbefuniversity.Course.Find(3);
            s.Courses.Add(c);
            dbefuniversity.SaveChanges();
        }

        //Actualizar el lastname del estudiante

        public void Actualizar()
        {
            //var stu=dbefuniversity.Student.
            var stu = dbefuniversity.Student.
        }
        //mostrar el total de estudiantes
    }
}
