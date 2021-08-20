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
            string answer = "";

            while(true)
            {
                Console.WriteLine("Enter a string to reverse (to exit type '-q' and press enter): ");
                answer = Console.ReadLine();

                if(answer == "-q")
                {
                    return;
                }

                string reversed = StringReverser.Reverse(answer);
                Console.WriteLine($"Reversed string - {reversed}");
            }
        }
    }
}
