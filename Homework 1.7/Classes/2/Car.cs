using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._7.Classes
{
    internal class Car : Transport
    {
        public Car(int gasoline) {
            this.Gasoline= gasoline;
        }

        int Gasoline;
        Engine engine = new Engine();

        public override void Move()
        {
            if (EnoughGasoline() == true)
            {
                engine.Wrom();
                Console.WriteLine("Car moves");
            }
            else
            {
                Console.WriteLine("car dont move");
            }
        }

        private bool EnoughGasoline()
        {
            if (Gasoline > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
