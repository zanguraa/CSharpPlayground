using System.Text.RegularExpressions;

namespace FilterTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string test = "a1b2c3";
            Console.WriteLine(FilterString(test));
        }
        public static int FilterString(string s)
        {
            return int.Parse(Regex.Replace(s, @"\D", ""));
        }
    }
}