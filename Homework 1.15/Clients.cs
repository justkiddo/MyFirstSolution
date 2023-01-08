using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._15
{
    internal class Clients
    {
        public int id;
        public int year;
        public int month;
        public int duration;


        public Clients(int id, int year, int month, int duration)
        {
            this.id = id;
            this.year = year;
            this.month = month;
            this.duration = duration;
        }
        public Clients()
        {
        }

        public override string ToString() => $"id - {id} year - {year} month - {month} duration - {duration}";


    }
}
