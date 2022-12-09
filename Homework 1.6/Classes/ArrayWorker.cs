using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._6.Classes
{
    internal class ArrayWorker
    {



        public int[] InverseMass(int[] numbers)
        {
            int i, j, n = numbers.Length, t;
            for (i = 0, j = n - 1; i < j; i++, j--)
            {
                t = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = t;
            }
            return numbers;
        }

    }
}
