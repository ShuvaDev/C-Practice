namespace Interface
{
    public class WashingMachine : IMachine
    {
        public void Start()
        {
            Console.WriteLine("Washing Machine Started");
        }

        public void Stop()
        {
            Console.WriteLine("Washing Machine Stopped");
        }
    }
}
