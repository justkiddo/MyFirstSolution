using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._13.Classes
{
    internal class Product : IComparable<Product>
    {
        string name = "default";
        int cost = 0;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetCost()
        {
            return this.cost;
        }
        public void SetCost(int cost)
        {
            this.cost = cost;
        }

        public override bool Equals(object? obj)
        {
            bool result;
            if (obj == null)
                return false;
            if (!(obj is Product product)) return false;
            Product other = (Product)obj;
            result = name.Equals(other.name) && cost.Equals(other.cost);
            return result;

        }
        public override string ToString()
        {
            string value = $"name - {name} | cost - {cost}";
            return value;
        }

        public override int GetHashCode()
        {
            Random rnd = new Random();
            int hash = rnd.Next();
            return hash;
        }

        public int CompareTo(Product? other)
        {
            if (other == null) return 1;

            Product otherProduct = other as Product;
            if (otherProduct != null)
                return this.name.CompareTo(otherProduct.name);
            else
                throw new ArgumentException("Object is not a Product");
        }
    }
}
