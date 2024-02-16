using System.Text.RegularExpressions;

namespace ContainsVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string vowel= Disemvowel("Hello, World!");
               Console.WriteLine(vowel);
        }
        public static string Disemvowel(string str)
        {
            return Regex.Replace(str, "[aeiouAEIOU]", "");
        }
    }
}