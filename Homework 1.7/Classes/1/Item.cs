using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._7.Classes
{
    internal class Item
    {
        private string Name = "unknown";

        
        public string GetName() { return Name; }
        public void SetName(string name) { this.Name = name; }

    }
}
