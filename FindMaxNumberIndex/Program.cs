namespace FindMaxNumberIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 45, 3, 22, 43, 1, 0, 4 };
            int maxIndex = FindMaxNumberIndex(numbers);
            Console.WriteLine(maxIndex);
        }
        static int FindMaxNumberIndex(int[] numbers)
        {
            int maxIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}