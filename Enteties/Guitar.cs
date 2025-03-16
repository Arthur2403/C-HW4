using System;
using C_HW4;

namespace C_HW4.Enteties
{
    internal class Guitar : IMusicalInstrument
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

        public Guitar(string name)
        {
            this.name = name;
        }

        public void Sound()
        {
            Console.WriteLine("drin drin drin");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}");
        }

        public void History()
        {
            Console.WriteLine("Made in 13 century.");
        }

        public void Desc()
        {
            Console.WriteLine("Use hand to wibrate strings and create sound.");
        }
    }
}
