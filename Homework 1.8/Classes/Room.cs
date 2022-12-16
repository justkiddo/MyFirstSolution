using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._8.Classes
{
    internal class Room
    {
        Printer printer = new Printer();

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }

        public Printer NewPrinter()
        {
            Printer printer = new Printer();
            return printer;
        }

        public Printer NewGreenPrinter()
        {
            Printer printer = new GreenPrinter();
            return printer;
        }

        public Printer NewBluePrinter()
        {
            Printer printer = new BluePrinter();
            return printer;
        }

    }
}
