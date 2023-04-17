class Program
{
    static void Main(string[] args)
    {
        foreach (var n in 
            Map(
                Filter(NaturalNumber(), x => x % 5 == 0),
                x=>x*x)
            )
        {

            Console.WriteLine(n);
            if (n > 10000) break;
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
    public static IEnumerable<long> Filter(IEnumerable<long> nums, Predicate<long> Filterfunc)
    {
        foreach (var num in nums)
        {

            if (Filterfunc(num)) yield return num;
        }

    }

    public static IEnumerable<long> Map(IEnumerable<long> nums, Func<long,long> maprFunc)
    {
        foreach (var num in nums)
        {
            yield return maprFunc(num);
        }
    }
    


}
