using System;
using C_HW4;
namespace C_HW4.Enteties
{
    public class Manager : IWorker
    {
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

        public Manager(string name)
        {
            this.name = name;
        }

        public void Print()
        {
            Console.WriteLine($"I am {name}, and i manage stuff!");
        }
    }
}
