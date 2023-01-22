using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._18.Classes
{
    internal class Pizzeria
    {
        Semaphore semaphore = new Semaphore(2,4);

        public void Run()
        {
        }

        public static async Task CreatePizza(CancellationToken token)
        {
            await Task.Run(() =>
            {
                int c = 5;
                for (int i = 0; i<5; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Cooking pizza. Ready in " +c+ " seconds. Task N " +Task.CurrentId);
                    c--;
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine(" thread canceled");
                        token.ThrowIfCancellationRequested();
                    }
                }
                if (!token.IsCancellationRequested)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Pizza is ready");
                }
            });
        }
        

    }

}
