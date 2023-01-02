using Homework_1._13.Classes;
using System.IO;



Seller seller= new Seller();
Shop shop = new Shop();
Product product1 = new Product();
Product product2 = new Product();
Customer customer = new Customer();

customer.SetMoney(200);

product1.SetName("Pirozhok");
product1.SetCost(26);
product2.SetName("Tvorozhok");
product2.SetCost(55);


seller.AddProduct(product1);
seller.AddProduct(product2);
seller.ShowProducts();
seller.SellProduct(customer, product1);
seller.ShowProducts();
seller.SellProduct(customer, product2);
