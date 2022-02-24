using System;

namespace HW_2
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("x = " + new RomanNumber(21) + " y = " + new RomanNumber(17));
            Console.WriteLine("x + y = " + RomanNumber.Add(new RomanNumber(21), new RomanNumber(17)));
            Console.WriteLine("x - y = " + RomanNumber.Sub(new RomanNumber(21), new RomanNumber(17)));
            Console.WriteLine("x * y = " + RomanNumber.Mul(new RomanNumber(21), new RomanNumber(17)));
            Console.WriteLine("x / y = " + RomanNumber.Div(new RomanNumber(21), new RomanNumber(17)));
            RomanNumber[] romanNumberArray = new RomanNumber[10];
            for (int i = 0; i < 10; i++)
            {
                romanNumberArray[i] = new RomanNumber((ushort)(new Random().Next(1, 1000)));
                Console.Write(romanNumberArray[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(romanNumberArray);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(romanNumberArray[i] + " ");
            }
        }
    }
}