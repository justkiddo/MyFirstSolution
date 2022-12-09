using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._7.Classes._3
{
    internal class Bag
    {
        private Item[] item = new Item[2];
        private bool isOpen = false;

        public void OpenClose()
        {
            if (isOpen == false)
            {
                isOpen= true;
                Console.WriteLine("Сумка открыта");
            }
            else
            {
                isOpen = false;
                Console.WriteLine("Сумка закрыта");
            }
        }

        public void AddItem(Item[] it)
        {
            if (isOpen == true)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    it[i] = item[i];
                    Console.WriteLine($"обьект {it[i].GetName()} добавлен");
                }
            }
            else
            {
                Console.WriteLine("Сумка закрыта или переполнена");
            }
        }

        public void ShowItems()
        {
            for (int i=0;i< item.Length;i++)
            {
                item[i].GetName();
            }
        }

    }
}
