using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Toyota : ICar
    {
        public void Start()
        {
            Console.WriteLine("Toyota Started");
        }

        public void Stop()
        {
            Console.WriteLine("Toyota Stopped");
        }
    }
}