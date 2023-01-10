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
        private static List<Student> kindList = new List<Student>();


        public static List<Student> GetList()
        {
            return kindList;
        }
        public void AddToList(Student s)
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
            foreach (Student s in kindList)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
        }

        public void GrowUp(List<Student> from, List<Student> to)
        {
                    SchoolEventArgs sc = new SchoolEventArgs(from, to);
                    OnTimeToSchool(sc);
        }
    }
}

