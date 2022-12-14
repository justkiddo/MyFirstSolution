using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._8.Classes
{
    internal class Printer
    {

        public virtual void Print(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
        }
    }
}
