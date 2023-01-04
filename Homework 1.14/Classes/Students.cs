using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._14.Classes
{
    internal class Students
    {
        string name = string.Empty;
        public int age;
        
        public Students(string name, int age) 
        {
         this.name = name;
         this.age = age;
        }

        public override string ToString()
        {
            string value = $"name - {name} || age - {age}";
            return value;
        }

    }
}
