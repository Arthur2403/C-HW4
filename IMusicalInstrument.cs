using System;

namespace C_HW4
{
    internal interface IMusicalInstrument
    {
        string Name { get; set; }
        void Sound();
        void Show();
        void History();
        void Desc();
    }
}
