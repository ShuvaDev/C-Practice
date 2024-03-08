using System;

public interface IntA
{
    void Print();
}

public interface IntB
{
    void Print();
}

public class EInterface : IntA, IntB
{
    public void Print()
    {
        Console.WriteLine("Interface A");
    }
    // For explicit interface the method should be private
    void IntB.Print()
    {
        Console.WriteLine("Interface B");
    }

    public static void Main()
    {
        EInterface eInterface = new EInterface();
        eInterface.Print();
        ((IntB)eInterface).Print();

        IntA intA = new EInterface();
        IntB intB = new EInterface();

        intA.Print();
        intB.Print();
    }
}
