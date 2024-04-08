using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Gender<T> : IId<T>
    {
        public T id { get; set; }
        public string gender { get; set; }
    }
}
