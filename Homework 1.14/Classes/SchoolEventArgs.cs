using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._14.Classes
{
    internal class SchoolEventArgs : EventArgs
    {
        public List<Student> fromSch;
        public List<Student> fromKg;

        public SchoolEventArgs(List<Student> fromKg, List<Student> fromSch)
        {
            this.fromKg = fromKg;
            this.fromSch = fromSch;
        }

    }
}
