
using System.Security.Cryptography.X509Certificates;

class Program{
    static void Main(string[] args){
        //for (int i=0; i<40; i+=2){
        //Console.WriteLine(i);
        //}
        //foreach(int i in First20EvenNumber(20000))
        //{
        //    Console.WriteLine(i);
        //}
        foreach (long i in EvenNumber())
        {
            Console.WriteLine(i);
        }


    }
    public static int[] First20EvenNumber(int n)
    {
        var evens = new int[n];
        for (int i = 0; i < n; i += 1)
        {
            evens[i] = i*2;
        }
        return evens;

    }

    public static IEnumerable<long> EvenNumber()
    {
        var n = 0;
        while (true)
        {
            yield return n;
            n += 2;
        }
    }
}