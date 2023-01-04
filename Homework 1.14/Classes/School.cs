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
            kindergarten.GoToSchool += DoSmth;
        }

        public void DoSmth(object o, SchoolEventArgs e)
        {
            Console.WriteLine("event");
        }

        public void AddToList(Students s)
        {
            Kindergarten.kindList.Remove(s);
            schoolStud.Add(s);
        }

        public void ShowStudents()
        {
            foreach (Students s in schoolStud)
            {
                Console.WriteLine(s.ToString());
            }
        }

    }
}
