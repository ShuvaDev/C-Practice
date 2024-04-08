void PrintEvenNum(int n)
{
    for(int i = 2; i <= n; i+= 2)
    {
        Console.WriteLine(n);
    }
}
void PrintOddNum(int n)
{
    for (int i = 1; i <= n; i += 2)
    {
        Console.WriteLine(n);
    }
}

Thread t1 = new Thread(() => PrintEvenNum(100));
Thread t2 = new Thread(() => PrintOddNum(100));

t1.Start();
t2.Start();