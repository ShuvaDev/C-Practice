using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Grid
    {
        private int[,] coords;

        public int this[int x, int y]
        {
            get
            {
                return coords[x, y];
            }
            set
            {
                coords[x, y] = value;
            }
        }
    }
}
