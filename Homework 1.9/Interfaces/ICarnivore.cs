using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._9.Interfaces
{
    internal interface ICarnivore
    {
         string typeC { get; set; }
         string foodC { get; set; }
        public void DisplayEatC();

    }
}
