
class Program
{
    static void Main(string[] args){
        DoLongRunningThing(s=>Console.WriteLine(s));

    }

    static void DoLongRunningThing(Action<string> feedback){
        for(int i=1; i<=10; i++){
            ProcessOperation(i);
            feedback($"Completed {i} of 10");
        }
    }
    private static void ProcessOperation(in int i){
        Thread.Sleep((int)Math.Sqrt(i*200000));
    }
}