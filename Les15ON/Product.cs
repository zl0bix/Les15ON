using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les15ON
{
    internal class Product
    {
        public string name { get; private set; }
        public int cost { get; private set; }

        public Product(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }


    }
   
}
