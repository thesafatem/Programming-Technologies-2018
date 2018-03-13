using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    public class Product
    {
        public string name;
        public int cost;
        public int amount;
        public string all;
        public Product()
        {

        }
        public Product(string name, int cost, int amount)
        {
            this.name = name;
            this.cost = cost;
            this.amount = amount;
        }
    }
}
