namespace RemoveDublicatesFromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var numbers = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 6 };
            var distinct = Distinct(numbers);
            foreach (var number in distinct)
            {
                Console.WriteLine(number);
            }
        }
        public static int[] Distinct(int[] numbers)
        {
         return numbers.ToArray().Distinct().ToArray();
        }
    }
}