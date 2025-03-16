using System;
using C_HW4;

namespace C_HW4.Enteties
{
    internal class Microwave : IDevice
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

        public Microwave(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine($"Microwawe: {name}");
        }

        public void Sound()
        {
            Console.WriteLine("hmhmhhmhmhmhmm pip pip pip");
        }

        public void Desc()
        {
            Console.WriteLine("Used to heat food");
        }
    }
}
