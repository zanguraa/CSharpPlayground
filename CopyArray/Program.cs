namespace CopyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = { 1, 2, 3, 4, 5 };
            CopyArray(intNumbers);

        }
        static void CopyArray(int[] intNumbers)
        {
            int[] newIntNumbersArray = new int[intNumbers.Length];
            for (int i = 0; i < intNumbers.Length; i++)
            {
                newIntNumbersArray[i] = intNumbers[i];
            }
            for (int i = 0; i < newIntNumbersArray.Length; i++)
            {
                Console.WriteLine(newIntNumbersArray[i]);
            }
        }
    }
}