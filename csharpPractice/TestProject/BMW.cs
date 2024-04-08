using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class BMW : ICar
    {
        public void Start()
        {
            Console.WriteLine("BMW Started");
        }
        public void Stop()
        {
            Console.WriteLine("BMW Stopped");
        }
    }
}
