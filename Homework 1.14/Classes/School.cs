using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._14.Classes
{
    internal class School 
    {
        private static List<Student> schoolStud = new List<Student>();

        public School()
        {
        }

        public static List<Student> GetList()
        {
            return schoolStud;
        }

        public School(Kindergarten kindergarten)
        {
            kindergarten.GoToSchool += ToSchool;
        }

        public void ToSchool(object o, SchoolEventArgs e)
        {
            int counter=1;
            foreach (Student s in Kindergarten.GetList().ToList())
            {
                s.AgePlus();
                if (s.GetAge() >= 10)
                {
                    Kindergarten.GetList().Remove(s);
                    Console.WriteLine(s.ToString() + " moved to school on counter " + counter );
                    Console.WriteLine();
                    schoolStud.Add(s);
                }
                counter++;
            }
        }

        public void AddToList(Student s)
        {
            Kindergarten.GetList().Remove(s);
            schoolStud.Add(s);
        }

        public void ShowStudents()
        {
            Console.WriteLine("school list");
            foreach (Student s in schoolStud)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
        }

    }
}
