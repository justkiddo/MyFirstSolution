using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._14.Classes
{
    internal class Student
    {
        string name = string.Empty;
        private int age;
        
        public Student(string name, int age) 
        {
         this.name = name;
         this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
        public void AgePlus()
        {
            this.age++;
        }
        public override string ToString()
        {
            string value = $"name - {name} || age - {age}";
            return value;
        }

    }
}
