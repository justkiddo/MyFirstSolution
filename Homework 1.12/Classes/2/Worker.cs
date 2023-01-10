using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._12.Classes._2
{
    public class Worker : IComparable<Worker>
    {
        string name = "default";
        int salary = 0;

        public Worker(string name, int salary){
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

        public int CompareTo(Worker? other)
        {
            if (other == null) return 1;
            Worker otherSalary = other as Worker;
            if (otherSalary != null)
                return this.salary.CompareTo(otherSalary.salary);
            else
                throw new ArgumentException("Object is not a Worker");
        }
    }
}
