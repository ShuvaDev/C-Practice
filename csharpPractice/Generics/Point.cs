using System;
using System.Numerics;

namespace Generics
{
    public class Point<T, Q>
        where T : INumber<T>
        where Q : INumber<Q>
    {
        public T x { get; set; }
        public Q y { get; set; }

        public Point(T x, Q y)
        {
            this.x = x;
            this.y = y;
        }
        public Point<T, Q> Add(Point<T, Q> p)
        {
            return new Point<T, Q>(p.x + x, p.y + y);
        }

    }
}
