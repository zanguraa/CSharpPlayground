namespace AvgOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello, This is console app for calculated numbers average!");
            Console.WriteLine("Please enter numbers with colon (5, 55, 34), or use spaces between numbers: ");
            double[] numbersArray = Console.ReadLine().Split(',', ' ').Select(double.Parse).ToArray();

            double average = AverageOfNumbers(numbersArray);
            Console.WriteLine($"\nThe average number is: {average}");
        }
        public static double AverageOfNumbers(double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
    }
}