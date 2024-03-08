using System;
using System.Numerics;
using Generics;

public class A<T, Q> : Point<T, Q>
    where T : INumber<T>
    where Q : INumber<Q>
{
    public A(T x, Q y) : base(x, y) { }
}