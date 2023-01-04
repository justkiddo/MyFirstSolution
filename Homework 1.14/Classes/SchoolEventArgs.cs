using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._14.Classes
{
    internal class SchoolEventArgs : EventArgs
    {
        public List<Students> fromSch;
        public List<Students> fromKg;

        public SchoolEventArgs(List<Students> fromKg, List<Students> fromSch)
        {
            this.fromKg = fromKg;
            this.fromSch = fromSch;
        }

    }
}
