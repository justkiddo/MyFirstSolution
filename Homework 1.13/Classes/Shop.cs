﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._13.Classes
{
    internal class Shop :IEnumerable<Product>
    {
        Seller seller;
        public Shop(Seller seller) 
        {
            if (seller != null) {
                this.seller = seller;
            }
            else
            {
                throw new Exception("There is no seller");
            }
        }


        public string name = "default";
        public static List<Product> products = new List<Product>();

        public IEnumerator<Product> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public List<Product> GetList()
        {
            return products;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }


    }
}
