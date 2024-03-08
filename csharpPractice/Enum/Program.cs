// Sample Program listing all enum member values and Names
using System;


// Default underlying type is int 
public enum Gender : short
{
    Unknown = 1,
    Male = 2,
    Female = 3
}
public class Enums
{
    public static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(Gender));
        Console.WriteLine("Gender Enum Values");
        foreach (int value in Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine();
        string[] Names = Enum.GetNames(typeof(Gender));
        Console.WriteLine("Gender Enum Names");
        foreach (string Name in Names)
        {
            Console.WriteLine(Name);
        }
    }
}
