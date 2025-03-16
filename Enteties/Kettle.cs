using System;
using C_HW4;
namespace C_HW4.Enteties
{
    internal class Kettle : IDevice
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

        public Kettle(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine($"Electric kettle : {name}");
        }

        public void Sound()
        {
            Console.WriteLine("swswswswswswswswswwssw");
        }

        public void Desc()
        {
            Console.WriteLine("Used to boil water");
        }
    }
}
