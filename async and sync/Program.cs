using async_and_sync;

class Program
{
    static void Main(string[] args)
    {
        var test = new AwaitingTest();

        Console.WriteLine("Starting app");

        test.AwaitSequencially().Wait();
        test.AwaitInParallel().Wait();

        Console.WriteLine("Ending app");


    }

}