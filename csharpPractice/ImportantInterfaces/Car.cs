using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class Car : ICloneable
    {
        public string Model { get; set; }
        public string Color { get; set; }


        public object Clone()
        {
            return new Car() { Model = Model, Color = Color };
        }
    }
}
