using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._7.Classes._3
{
    internal class Bag
    {
        private Item[] item = new Item[2];
        private bool _isOpen = false;
        private int _itemIndex = 0;

        public void OpenClose()
        {
            if (_isOpen == false)
            {
                _isOpen = true;
                Console.WriteLine("Сумка открыта");
            }
            else
            {
                _isOpen = false;
                Console.WriteLine("Сумка закрыта");
            }
        }

        public void AddItem(Item it)
        {
            if (_isOpen == true)
            {
                if (_itemIndex<item.Length) {
                    item[_itemIndex] = it;
                    _itemIndex++;
                    Console.WriteLine($"{it.GetName().ToString()} добавлен");
                }
                else
                {
                    Console.WriteLine("Сумка переполнена");
                }
            }
            else
            {
                Console.WriteLine("Сумка закрыта");
            }
          
        }

        public Item GetItem(int index)
        {
            if (_isOpen == true) {
                Item tempItem = item[index];
                item[index] = null;
                _itemIndex--;
                return tempItem;
            }
            else
            {
                Console.WriteLine("Сумка закрыта");
                return null;
            }
        }

        public void ShowItems()
        {
            for (int i=0;i<_itemIndex;i++)
            {

                Console.WriteLine($"в сумке есть {item[i].GetName().ToString()}");
            }
        }

    }
}
