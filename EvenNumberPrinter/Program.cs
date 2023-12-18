namespace EvenNumberPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 5, 10, 2, 12, 2, 4 };
            EvenNumberPrinter(ints);

        }
        static void EvenNumberPrinter(int[] ints)
        {
            int evenNumberSum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                    evenNumberSum += ints[i];
            }
            Console.WriteLine(evenNumberSum);
        }
    }
}