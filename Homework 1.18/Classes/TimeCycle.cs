using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._18.Classes
{
    internal class TimeCycle
    {


        public static async Task Run(CancellationToken token)
        {
            DateTime date= DateTime.Now;
            var inter = date.Millisecond;
            await Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    Thread.Sleep(inter);
                    Console.WriteLine("Hello from callback");
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("first thread canceled");
                        token.ThrowIfCancellationRequested();
                    }
                }
            });
        }

            public static async Task ActionTwo(CancellationToken token)
            {
                await Task.Run(() =>
                 {
                     for (int i = 0; i < 25; i++)
                     {
                      Thread.Sleep(250);
                      Console.WriteLine("second thread working");
                         if (token.IsCancellationRequested)
                         {
                             Console.WriteLine("second thread canceled");
                             token.ThrowIfCancellationRequested();
                         }
                     }
                 });
            }


    }
}
