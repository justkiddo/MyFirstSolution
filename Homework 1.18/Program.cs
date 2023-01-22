using Homework_1._18.Classes;

namespace Homework_1._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ===================================================================
            string? result;
            //CancellationTokenSource cts = new CancellationTokenSource();
            //var token = cts.Token;

            //_ = CyclesRunner.ActionTask(token);

            //result = Console.ReadLine();
            //if (result == "1")
            //{
            //    cts.Cancel();
            //}

            // 2 ===================================================================

            //CancellationTokenSource cts2 = new CancellationTokenSource();
            //CancellationTokenSource cts3 = new CancellationTokenSource();
            //var token2 = cts2.Token;
            //var token3 = cts3.Token;

            //var second = TimeCycle.Run(token2);

            //result = Console.ReadLine();

            //var res = TimeCycle.Run(token2);
            //second.ContinueWith(x => TimeCycle.ActionTwo(token3));
            //if (result == "2")
            //    cts2.Cancel();
            //result = Console.ReadLine();
            //if (result == "3") 
            //    cts3.Cancel();



            // 3 ===================================================================

            bool isEnd = false;
            CancellationTokenSource cts4 = new CancellationTokenSource();
            var token4 = cts4.Token;


            while (!isEnd)
            {
                result = Console.ReadLine();
                Pizzeria.CreatePizzaAsync(token4);
                
                Console.ReadLine();
                if (result == "2")
                {
                    cts4.Cancel();
                }
                Console.ReadLine();
            }
        }
    }
}