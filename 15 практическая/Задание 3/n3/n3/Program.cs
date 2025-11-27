using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal interface IPrice
    {
        double GetPrice();
    }

    internal interface IGarant
    {
        int GetGarant();
    }

    internal class Phone : IPrice, IGarant
    {
        private double price;
        private int srok;

        public Phone(double price, int srok)
        {
            this.price = price;
            this.srok = srok;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetGarant()
        {
            return srok;
        }
    }

    internal class Laptop : IPrice
    {
        private double price;

        public Laptop(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return price;
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var products = new List<object>
        {
            new Phone(50000, 24),
            new Laptop(70000),
            new Phone(30000, 12),
            new Laptop(45000)
        };

            double totalCost = 0;

            foreach (var product in products)
            {
                if (product is IPrice priceProvider)
                {
                    double price = priceProvider.GetPrice();
                    totalCost += price;
                    Console.WriteLine($"Цена товара: {price}");

                    if (product is IGarant garantich)
                    {
                        int srok = garantich.GetGarant();
                        Console.WriteLine($"Срок гарантии: {srok} месяцев");
                    }
                }
            }

            Console.WriteLine($"Общая стоимость товаров: {totalCost}");
        }
    }
}