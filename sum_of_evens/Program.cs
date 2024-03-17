class Program
{
    static void Main(string[] args)
    {
        int sumaPares = 0;

        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                sumaPares += i;
            }
        }

        Console.WriteLine(sumaPares);
    }
}
