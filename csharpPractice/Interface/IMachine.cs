using System;

namespace Interface
{
    public interface IMachine
    {
        void Start();
        void Stop();
        // Useless things
        void Print()
        {
            Console.WriteLine("Machine");
        }
    }

}
