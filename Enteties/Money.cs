using System;

namespace C_HW4.Enteties
{
    internal class Money
    {
        private int money;

        public int Amount
        {
            get { return money; }
            set
            {
                if (value >= 0)
                    money = value;
                else
                    Console.WriteLine("The amount cannot be negative!");
            }
        }

        public Money(int initialAmount)
        {
            Amount = initialAmount;
        }

        public void PrintMoney()
        {
            Console.WriteLine($"{money%100}.{money-(money%100)}$");
        }
        public static Money operator -(Money currentMoney, int sub)
        {
            return new Money(currentMoney.money - sub);
        }
    }
}
