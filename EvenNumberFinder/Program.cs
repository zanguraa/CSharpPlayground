namespace EvenNumberFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter number and program will tell you if this number is even, or not: ");
            var number = int.TryParse(Console.ReadLine(), out int result);
            if (number)
            {
                Console.WriteLine(IsEven(result) ? "Number is even" : "Number is odd");
            }
            else
            {
                Console.WriteLine("Please enter valid number!");
            }
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}