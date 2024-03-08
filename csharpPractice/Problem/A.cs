void print(ref int x)
{
    x = 20;
}

int x = 10;
print(ref x);
Console.WriteLine(x);