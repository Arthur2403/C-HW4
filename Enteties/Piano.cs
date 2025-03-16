using System;
using C_HW4;

namespace C_HW4.Enteties
{
    public class Piano : IMusicalInstrument
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

        public Piano(string name)
        {
            this.name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Pin Pin Pin");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}");
        }

        public void History()
        {
            Console.WriteLine("Made in Italy in 18 century by Cristofor Bartolomy.");
        }

        public void Desc()
        {
            Console.WriteLine("Use hands to press buttons and make sound.");
        }
    }
}
