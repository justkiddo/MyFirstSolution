using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._14.Classes
{
    internal class School 
    {
        public static List<Students> schoolStud = new List<Students>();


        public School()
        {
        }

        public School(Kindergarten kindergarten)
        {
            kindergarten.GoToSchool += ToSchool;
        }

        public void ToSchool(object o, SchoolEventArgs e)
        {
            int counter=1;
            foreach (Students s in Kindergarten.kindList.ToList())
            {
                s.age++;
                
                if (s.age>=10)
                {
                    Kindergarten.kindList.Remove(s);
                    Console.WriteLine(s.ToString() + " moved to school on counter " + counter );
                    Console.WriteLine();
                    schoolStud.Add(s);
                }
                counter++;
            }
        }

        public void AddToList(Students s)
        {
            Kindergarten.kindList.Remove(s);
            schoolStud.Add(s);
        }

        public void ShowStudents()
        {
            Console.WriteLine("school list");
            foreach (Students s in schoolStud)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
        }

    }
}
