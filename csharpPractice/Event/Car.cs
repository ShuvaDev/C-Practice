using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Car
    {
        public string licenseNumber { get; set; }
        public Car()
        {
            licenseNumber = Guid.NewGuid().ToString();
        }
        public event Action<string> carStarted;
        public event Action<string> carStopped;
        public void Start()
        {
            Console.WriteLine("Car started");
            carStarted.Invoke(licenseNumber);
        }
        public void Stop() {
            Console.WriteLine("Car stopped");
            carStopped.Invoke(licenseNumber);
        }
    }
}
