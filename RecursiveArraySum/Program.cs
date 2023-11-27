namespace RecursiveArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app can calculate array sum with recursion! \n");
            int[] array = { 1, 2, 3, 4, 5 };
            int sum = SumArrayRercursively(array, 0);
            Console.WriteLine($"Sum of array is {sum}");
        }
        static int SumArrayRercursively(int [] array, int index) => index == array.Length ? 0 : array[index] + SumArrayRercursively(array, index + 1);
    }
}