namespace UniqieElementPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 1, 2, 3, 4, 5 };
            PrintUniqueElement(array);
        }
        static void PrintUniqueElement(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                bool isUnique = true;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(numbers[i]);
                }

            }
        }
    }
}