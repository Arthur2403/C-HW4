using System;

namespace C_HW4.Enteties
{
    internal class Product
    {
        public Money Price { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("Name can not be empty!");
            }
        }

        public Product(string name, int initialPriceInKopecks)
        {
            Name = name;
            Price = new Money(initialPriceInKopecks);
        }

        public void ReducePrice(int reduction)
        {
            Price = Price - reduction;
        }

        public void PrintProduct()
        {
            Console.Write($"Product: {Name}, ");
            Price.PrintMoney();
        }
    }
}
