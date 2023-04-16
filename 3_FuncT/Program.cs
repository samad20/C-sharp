
class Program
{
    static void Main(string[] args)
    {
        DoLongRunningThing( 
            s=> Console.WriteLine("Main: "+s),
            i=> ProcessOperation(i));

    }

    static void DoLongRunningThing(Action<string> feedback, Func<int, bool> operation)
    {
        for (int i = 1; i <= 10; i++)
        {
            var result = operation(i);
            feedback($"Completed {i} of 10: {(result ? "success" : "failur" )}");
        }
    }
    private static bool ProcessOperation(in int i)
    {
        Thread.Sleep((int)Math.Sqrt(i * 200000));

        return true;
    }
}
