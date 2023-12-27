namespace ArrayOrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 45, 3, 22, 43, 1, 0, 4 };

            OrderArray(numbers);
        }

        static void OrderArray(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
