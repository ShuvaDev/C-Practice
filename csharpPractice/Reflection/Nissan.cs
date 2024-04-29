using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Nissan : ICar
    {
        public void Start()
        {
            Console.WriteLine("Nissan Started");
        }

        public void Stop()
        {
            Console.WriteLine("Nissan Stopped");
        }
    }
}