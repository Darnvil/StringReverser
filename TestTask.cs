using System;

namespace SolbegTestTask
{

    class StringReverser
    {
        public static string Reverse(string strToReverse)
        {
            if (strToReverse.Length <= 1) // Recursion base
            {
                return strToReverse;
            }
            else 
            {
                return Reverse(strToReverse.Substring(1)) + strToReverse[0];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringReverser.Reverse("Hello World"));
            Console.WriteLine(StringReverser.Reverse("123456"));
            Console.WriteLine(StringReverser.Reverse(""));
            Console.WriteLine(StringReverser.Reverse("Члены String класса выполняют для объекта либо порядковые, либо зависящие от языка и региональных параметров"));
        }
    }
}
