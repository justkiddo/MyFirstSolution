﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_1._12.Classes._2
{
    internal class WorkersList<Workers> : IEnumerable<Workers>
    {

        protected List<Workers> _workers = new List<Workers>();

     

        public void addWorker(Workers worker)
        {
            if (worker != null)
            {
                _workers.Add(worker);
                Console.WriteLine($"worker added - {worker.ToString()}");

            }
            else
            {
                Console.WriteLine("worker not added");
            }
        }



        public void OrderBySalary(List<Workers> workers)
        {
        
        }




        public IEnumerator<Workers> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }
}
