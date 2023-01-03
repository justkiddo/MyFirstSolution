using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._13.Classes
{
    internal class Seller
    {

        public void AddProduct(Product product)
        {
            foreach (Product p in Shop.products)
            {
                if (p.GetName() == product.GetName())
                    throw new Exception("This product already exists");
            }
            Shop.products.Add(product);
            Console.WriteLine(product.ToString() + " added");
            Console.WriteLine();
        }

        public void SellProduct(Customer customer1, Product product)
        {
            if (customer1.GetMoney() < product.GetCost()) throw new Exception("Not enough money");

            else if (Shop.products.Exists(x => x.GetName().Contains(product.GetName())) == false) 
                throw new Exception("Product does not exist");

            customer1.SetMoney(customer1.GetMoney()-product.GetCost());
            Shop.products.Remove(product);
        }

        public void ShowProducts()
        {
            for (int i = 0; i < Shop.products.Count; i++)
            {
                Console.WriteLine(Shop.products[i].ToString());
            }
            Console.WriteLine();
        }

        public void Liqudation(Shop shop)
        {
            if (Shop.products.Count == 0)
            {
                shop = null;   // не уверен в правильности
                GC.Collect();
            }
            else throw new Exception("Still got products");
        }

    } 
}
