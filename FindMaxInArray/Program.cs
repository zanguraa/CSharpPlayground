namespace FindMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 5, 10, 2, 12, 2, 4 };
            FindMax(arrayOfNumbers);
        }
        static void FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine(max);
        }
    }
}