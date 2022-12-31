


using Homework_1._13.Classes;
using System.IO;

Shop shop= new Shop();
Seller seller= new Seller();
Product product1 = new Product();
Product product2 = new Product();
Customer customer = new Customer();


product1.SetName("Pirozhok");
product1.SetCost(26);
product2.SetName("Tvorozhok");
product2.SetCost(55);
customer.SetMoney(200);
seller.AddProduct(product1);
seller.AddProduct(product2);
seller.ShowProducts();
seller.SellProduct(customer, product1);
seller.SellProduct(customer, product1);

seller.ShowProducts();

Console.WriteLine(customer.GetMoney());