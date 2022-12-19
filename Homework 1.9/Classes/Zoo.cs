using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._9.Classes
{
    internal class Zoo <T>
    {
        T[] array = new T[10];
        int counter = 0;

        public void zooAdd(T t)
        {
            array[counter] = t;
            counter++;
        }
        public void zooShow()
        {
            for (int i = 0; i<=counter;i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}
