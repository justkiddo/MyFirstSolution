using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._14.Classes
{
    internal class Kindergarten
    {
        public event EventHandler<SchoolEventArgs> GoToSchool;
        public static List<Students> kindList = new List<Students>();

        public void AddToList(Students s)
        {
            kindList.Add(s);
        }

        protected virtual void OnTimeToSchool(SchoolEventArgs s)
        {
            if (GoToSchool!=null)
            {
                GoToSchool(this, s); // ??????
            }
        } 

        public void ShowStudents()
        {
            Console.WriteLine("kg list");
            foreach (Students s in kindList)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
        }

        public void GrowUp(List<Students> from, List<Students> to)
        {
                    SchoolEventArgs sc = new SchoolEventArgs(from, to);
                    OnTimeToSchool(sc);
        }
    }
}

