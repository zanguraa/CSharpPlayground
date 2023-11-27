namespace RecursiveArrayPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app can print array numbers recursive!\n ");
            int[] arr = { 1, 2, 3, 4, 5 };
            PrintArrayRecursive(arr);
        }
        static void PrintArrayRecursive(int[] arr, int n = 0)
        {
            if (n < arr.Length)
            {
                Console.WriteLine(arr[n]);
                PrintArrayRecursive(arr, n + 1);
            }
        }
    }
}