/*
(int, int) MinMax(int[] arr)
{
    return (arr.Min(), arr.Max());
}

(int, int) result = MinMax([3, 6, 4, 9, 3]);
Console.WriteLine($"Min : {result.Item1}, Max : {result.Item2}");
*/

(int min, int max) MinMax(int[] arr)
{
    return (arr.Min(), arr.Max());
}
var r1 = MinMax([3, 6, 4, 9, 4]);
Console.WriteLine($"Min : {r1.min}, Max : {r1.max}");

//(int, int max) r2 = MinMax([2, 5, 3, 9, 5]);
//Console.WriteLine($"Min : {r2.Item1}, Max : {r2.max}");

(int a, double b)[] arr = new (int, double)[2];
arr[0].a = 10;
arr[0].b = 20.5;


