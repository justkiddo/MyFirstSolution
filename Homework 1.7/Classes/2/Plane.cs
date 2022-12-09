using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._7.Classes
{
    internal class Plane : Transport
    {
        int diesel;

        public Plane(int Diesel)
        {
            this.diesel = Diesel;
        }

        Engine engine = new Engine();

        public override void Move()
        {
            if (EnoughDiesel()==true)
            {
                engine.Wrom();
                Console.WriteLine("plane moves");
            }
            else
            {
                Console.WriteLine("plane dont move");
            }

        }

        private bool EnoughDiesel()
        {
            if (diesel>0)
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
