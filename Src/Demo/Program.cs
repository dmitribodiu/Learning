using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 23, 1, 3, 5, 6, 6, 8 };


            // написать фукцию для numbers которая вернет bool true/false, if any element exists in array.

            // Exists(5)   - true
            // Exists(33)  - false

            var result = numbers.MaxNumber();


            string[] words = new[] { "one", "two"};

            List<int> numbers2 = new List<int> {  };
            numbers2.Add(3);
            numbers2.AddRange(numbers);

            string question = "How1";
            bool length = question.Oleg(3);
            
            
            double price = 34.64;
            char letter = 's';
            DateTime asss = DateTime.Now;


            Console.WriteLine(question);
            string answer = Console.ReadLine();
            int answerAsInt = int.Parse(answer);

            bool a = answerAsInt > 30;
            if (a)
            {
                Console.WriteLine("Old");
            }
            else
            {
                Console.WriteLine("Young");
            }

            Console.ReadKey();
        }
    }

    public static class Utils
    {
        public static bool Oleg(this string text, int param)
        {
            if (param == text.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int MaxNumber(this int[] array)
        {
            int maxNumber = Int32.MinValue;

            foreach (int number in array)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            return maxNumber;
        }
    }
}
