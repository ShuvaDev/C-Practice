void method1(int x, params int[] arr)
{
    Console.WriteLine(x);

    foreach(var item in arr)
    {
        Console.WriteLine(item);
    }
}
method1(10, 1, 2, 3, 4);

void method2(ref int x)
{
    x = 20;
}
int x = 10;
method2(ref x);
Console.WriteLine(x);


void method3(in int x)
{
    // x = 20; we can't modifiy the value of x(it is similar as readonly)
}

method3(in x  );

void method4(out int x)
{
    x = 30; // Here we must be set the value of x
}
method4(out x);
Console.WriteLine(x);