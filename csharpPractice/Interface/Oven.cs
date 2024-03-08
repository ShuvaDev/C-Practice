using System;

namespace Interface
{
    public class Oven : IMachine
    {
        void On()
        {
            Console.WriteLine("Oven started");
        }
        void Off()
        {
            Console.WriteLine("Oven stopped");
        }
        public void Start()
        {
            On();
        }
        public void Stop()
        {
            Off();
        }
    }
}
