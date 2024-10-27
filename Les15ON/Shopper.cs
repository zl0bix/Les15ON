using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les15ON
{
    internal class Shopper
    {
        public int money {  get; private set; }
        private int sumBascet = 0;

        public Shopper(int money, List<Product> products)
        {
            this.money = money;
            this.products = products;
        }

        List<Product> products = new List<Product>();

        public void ShowBascet()
        {
            foreach (Product item in products)
            {
                Console.WriteLine(item.name + " " + item.cost);
            }
        }

        public void ShowSumBascet()
        {
            sumBascet = 0;

            foreach (Product item in products)
            {
                sumBascet += item.cost;
            }
            Console.WriteLine("Sum of bascet is " + sumBascet);
        }

        public Product ReturnProduct(int index)
        {
           Product tempProd = products[index];

            products.RemoveAt(index);

            return tempProd;
        }

        public int GetBascetSum()
        {
            return sumBascet;
        }

        public int GetCountProd() { return products.Count; }
        
    }
}
