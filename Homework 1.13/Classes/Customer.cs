using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._13.Classes
{
    internal class Customer
    {
        public string name = "default";
        private int money = 0;

        public int GetMoney() 
        { 
            return money; 
        }
        public void SetMoney(int money)
        {
            this.money = money;
        }

    }
}
