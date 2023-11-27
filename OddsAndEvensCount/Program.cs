namespace OddsAndEvensCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers with column or space (5, 10 or 5 10) and program will count even and odd numbers: ");
            var userInput = Array.ConvertAll(Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            CountEvenOdd(userInput);

        }
        static public void CountEvenOdd(int[] userInput)
        {
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Even numbers count: " + evenCount);
            Console.WriteLine("Odd numbers count: " + oddCount);
        }
    }
}