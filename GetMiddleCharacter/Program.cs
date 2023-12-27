namespace GetMiddleCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var middle = GetMiddle("Hello");
            Console.WriteLine(middle);
        }
        public static string GetMiddle(string s)
        {
            //Code goes here!
           if(String.IsNullOrEmpty(s)) return String.Empty;

           var length = s.Length;
            var middle = length / 2;
            if(length % 2 == 0)
            {
                return s.Substring(middle - 1, 2);
            }
            else
            {
                return s.Substring(middle, 1);
            }
        }
    }
}