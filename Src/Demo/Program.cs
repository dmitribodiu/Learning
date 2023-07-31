using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter numbers followed by comma:");
            var collectionAsString = Console.ReadLine();
            var collection = collectionAsString.Split(',');

            int[] numbers = new int[collection.Length];

            for (int i = 0; i < collection.Length; i++)
            {
                numbers[i] = int.Parse(collection[i]);
            }

            Console.WriteLine("Please enter a number:");
            var enteredNumber = Console.ReadLine();
            int answerAsInt = int.Parse(enteredNumber);

            bool number = numbers.SearchNumberFor(answerAsInt);
            if (number)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();

            // написать фукцию для numbers которая вернет bool true/false, if any element exists in array.

            // Exists(5)   - true
            // Exists(33)  - false






            //string[] words = new[] { "one", "two" };

            //List<int> numbers2 = new List<int> { };
            //numbers2.Add(3);
            //numbers2.AddRange(numbers);

            //string question = "How1";
            //bool length = question.Oleg(3);


            //double price = 34.64;
            //char letter = 's';
            //DateTime asss = DateTime.Now;


            //Console.WriteLine(question);
            //string answer = Console.ReadLine();
            //int answerAsInt = int.Parse(answer);

            //bool a = answerAsInt > 30;
            //if (a)
            //{
            //    Console.WriteLine("Old");
            //}
            //else
            //{
            //    Console.WriteLine("Young");
            //}

            //Console.ReadKey();
        }
    }
}
            
            
           
        

    //    public static int MaxNumber(this int[] array)
    //    {
    //        int maxNumber = Int32.MinValue;

    //        foreach (int number in array)
    //        {
    //            if (number > maxNumber)
    //            {
    //                maxNumber = number;
    //            }
    //        }

    //        return maxNumber;
    //    }
    //}

    

