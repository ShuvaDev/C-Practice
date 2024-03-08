var aobj = new { Name = "Shuva", age = 23 };
Console.WriteLine(aobj.Name);
Console.WriteLine(aobj.age);

dynamic GetMinMax(int[] arr)
{
    return new { Min = arr.Min(), Max = arr.Max() };
}

var mm = GetMinMax([10, 20, 3, 4, 3]);
Console.WriteLine($"Min : {mm.Min}, Max : {mm.Max}");
