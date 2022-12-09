using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._6.Classes
{
    internal class Cone
    {
        double r;
        double h;
        double PI = 3.14;

       public Cone(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
            

        public double AreaOfDep(double r, double h)
        {
            double areaD = PI*(r*r);
            Console.WriteLine($"площадь основания : {areaD}");
            return areaD;
        }

        public double Area()
        {
            double l = Math.Sqrt((Math.Pow(r, 2) + Math.Pow(h, 2)));
            double sideA =PI*r*l;
            double mainA = AreaOfDep(r, h);
            double area =sideA+mainA;
            Console.WriteLine($"площадь общая : {area}");
            return area;
        }

    }
}
