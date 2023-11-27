namespace ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter word: ");
            var word = Console.ReadLine();
            var reversedWord = Reverse(word);
            Console.WriteLine();
            Console.WriteLine($"Reversed word is: {reversedWord}");
        }
        public static string Reverse(string word)
        {
            var reversedWord = "";
            for (var i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return reversedWord;
        }
    }
}