using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._18.Classes
{
    internal class CyclesRunner
    {

        public static async Task ActionTask(CancellationToken token)
        {

            await Task.Run(() =>
            {

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("doing some stuf " + i);
                    Thread.Sleep(200);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Operation Canceled");
                        token.ThrowIfCancellationRequested();
                        Console.WriteLine();
                    }
                }
            });

        }
    }
}
