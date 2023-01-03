using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._13.Classes
{
    internal class Seller : Shop
    {

        public void AddProduct(Product product)
        {
            foreach (Product p in GetList())
            {
                if (p.GetName() == product.GetName())
                    throw new Exception("This product already exists");
            }
            GetList().Add(product);
            Console.WriteLine(product.ToString() + " added");
            Console.WriteLine();
        }

        public void SellProduct(Customer customer1, Product product)
        {
            if (customer1.GetMoney() < product.GetCost()) throw new Exception("Not enough money");

            else if (GetList().Exists(x => x.GetName().Contains(product.GetName())) == false) 
                throw new Exception("Product does not exist");

            customer1.SetMoney(customer1.GetMoney()-product.GetCost());
                GetList().Remove(product);
        }

        public void ShowProducts()
        {
            for (int i = 0; i < GetList().Count; i++)
            {
                Console.WriteLine(GetList()[i].ToString());
            }
            Console.WriteLine();
        }

        public void Liqudation(Shop shop)
        {
            if (GetList().Count == 0)
            {
                shop = null;   // не уверен в правильности
                GC.Collect();
            }
            else throw new Exception("Still got products");
        }

    } 
}
