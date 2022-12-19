using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._9.Classes
{
    abstract class Animal
    {
        private string name = "unknown";
        private int numOfLegs;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetNumOfLegs(int numOfLegs)
        {
            this.numOfLegs = numOfLegs;
        }

        public int GetNumOfLegs()
        {
            return this.numOfLegs;
        }

        public abstract void DisplayAnimal();
    }
}
