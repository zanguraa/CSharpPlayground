namespace CharCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter phrase: ");
            var phrase = Console.ReadLine().Split(' ').ToArray();
            CharCounter(phrase);

        }
        public static void CharCounter(Array phrase)
        {
            var counter = 0;
            foreach (var word in phrase)
            {
                foreach (var letter in word.ToString())
                {
                    counter++;
                }
            }
            Console.WriteLine($"The phrase has {counter} characters");
        }
    }
}