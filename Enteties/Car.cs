using System;
using C_HW4;

namespace C_HW4.Enteties
{
    public class Car : IDevice
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

        public Car(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine($"Car: {name}");
        }

        public void Sound()
        {
            Console.WriteLine("weeeeeeeeeeeeeeeeeeee bip weeeeeeeeeeeeeee");
        }

        public void Desc()
        {
            Console.WriteLine("Used to travel big distances");
        }
    }
}
