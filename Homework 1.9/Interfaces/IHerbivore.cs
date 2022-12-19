using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._9.Interfaces
{
    internal interface IHerbivore
    {
        string typeH { get; set; }
        string foodH { get; set; }

        public void DisplayEatH();
    }
}
