using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les15ON
{
    internal class Shop
    {
        Random rnd = new Random();

        List<Product> _products = new List<Product>();

        private int minCost = 5;
        private int maxCost = 15;
        private int minMoney = 30;
        private int maxMoney = 50;
        private int moneyShop = 0;


        private string GetName()
        {
            string[] tmpNames =  {"молоко" , "алкоголь" , "арбуз", "мясо" , "колбаса","сыр","дыня",
                "хлеб","помидор","конфета"};

            return tmpNames[GetRandomNumber(0, tmpNames.Length)];
        }

        public int GetRandomNumber(int min, int max)
        {
            return rnd.Next(min, max);
        }

        public void CreateAssortment()
        {
            int countProd = rnd.Next(10,31);
            
            for (int i = 0; i < countProd; i++)
            {
                _products.Add(new Product(GetName(), GetRandomNumber(minCost, maxCost)));
            }
        }

        public Queue<Shopper> CreateQueue()
        {
            Queue<Shopper> queue = new Queue<Shopper>();

            int temp = rnd.Next(minCost,maxCost);

            for (int i = 0; i < temp; i++)
            {
                queue.Enqueue(new Shopper(GetRandomNumber(minMoney, maxMoney), GetBasketProductt()));
            }
            return queue;
        } 

        private List<Product> GetBasketProductt()
        {
            int temp = rnd.Next(1,6);

            List<Product> products = new List<Product>();
            
            for (int i = 0; i < temp; i++)
            {
                products.Add(_products[rnd.Next(0,_products.Count)]);
            }

            return products;
        }

        public void MoneyShop(int number)
        {
            moneyShop += number;
        }

        public void TakeProduct(Product product)
        {
            _products.Add(product);
        }

    }
}
