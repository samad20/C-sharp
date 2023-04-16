class Program
{
    static void Main(string[] args)
    {
        foreach (var n in Filter(NaturalNumber(), x=> x % 1000==0))
        {

            Console.WriteLine(n);
        }
    }
    public static IEnumerable<long> NaturalNumber()
    {
        long n = 0;

        while (n < long.MaxValue)
        {
            yield return n;
            n += 1;
        }
    }
    public static IEnumerable<long> Filter(IEnumerable<long> nums, Func<long, bool> filterfunc)
    {
        foreach (var num in nums) { 
        
            if (filterfunc(num)) yield return num;
        }

    }
}