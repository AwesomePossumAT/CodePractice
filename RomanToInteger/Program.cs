using System;

namespace RomanToInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int convertRomanNumberToInteger(string romanNumber)
        {
            int intNumber = 0;
            int firstIndex = romanNumber.Length - 1;
            foreach (var number in romanNumber)
            {
                if (romanNumber[firstIndex] == 'M')
                {
                    intNumber =+ 1000;
                }
            }
            return intNumber;
        }
    }
}
