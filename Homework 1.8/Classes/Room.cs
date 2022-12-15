using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._8.Classes
{
    internal class Room
    {
        Printer printer = new ();

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }

        public void NewPrinter()
        {
            printer = new Printer();
        }

        public void NewGreenPrinter()
        {
            printer = new GreenPrinter();
        }

        public void NewBluePrinter()
        {
            printer = new BluePrinter();
        }

    }
}
