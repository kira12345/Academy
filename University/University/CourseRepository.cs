using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;

namespace University
{
    public class CourseRepository
    {
        private DbEfUniversity dbefuniversity = new DbEfUniversity();

        public bool Add(string name, int credits)
        {
            try
            {
                var courses = new Course { Name = name, credits = credits };
                dbefuniversity.Course.Add(courses);
                dbefuniversity.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<Course> Get()
        {
            return dbefuniversity.Course.ToList();
        }


        public Course Get(string name)
        {
            return dbefuniversity.Course.Where(x=>x.Name==name).First();
        }
        public void Remove(string Name)
        {
            try
            {
                dbefuniversity.Course.Remove(Get(Name));
                dbefuniversity.SaveChanges();
                Console.WriteLine("Si se eliminan los elementos");
            }
            catch (Exception e)
            {
                Console.WriteLine("No se eliminó los elementos");
            }
        }
     }
}
