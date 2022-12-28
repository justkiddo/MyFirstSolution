using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._12.Classes._2
{
    public class Workers
    {
        string name = "default";
        int salary = 0;

        public Workers(string name, int salary){
            this.name = name;
            this.salary = salary;
            
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name=name;
        }

        public int GetSalary()
        {
            return salary;
        }
        public void SetSalary(int salary)
        {
            this.salary = salary;
            
        }



        public override string ToString()
        {
            string info = $"name - {name} | salary - {salary}";
          //  Console.WriteLine(info);
            return info;
        }
    }
}
