using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberToSearch = 82;
            var array = new int[] { 5, 7, 9, 12, 24, 30, 44, 56, 82 };

            var found = BinarySearch(array, numberToSearch, 0, array.Length - 1);

            if (found)
            {
                Console.WriteLine($"Yeeah! Number {numberToSearch} was found");
            }

            // 5! = 1 * 2 * 3 * 4 * 5;

            var rs = FactorialNonRecursive(5);
            var result = Factorial(5);
            int sum = 0;
            int counter = 1;
            int ten = 10;

            while (counter < ten)
            {
                sum = sum + counter;
                counter++;
            }

            Console.WriteLine(sum);


            var avg = (3 + 2 + 1) / 3;
            var array1 = new double[] { 3, 2, 1, 2};
            var avg2 = Enumerable.Average(array1);

            var template = $"jfkldsjfdl , fdsfd {avg},,,,, {avg2 * avg2}";
            Task1();

            // Task2();
        }

        public static void Task1()
        {
            Console.WriteLine("Enter a number from 2 to 20");

            string number = Console.ReadLine();
            int numberAsInt;
            bool result = int.TryParse(number, out numberAsInt);
            if (!result)
            {
                Console.WriteLine("Error! You did not enter a valid number");
            }
            else
            {
                if (numberAsInt < 2)
                {
                    Console.WriteLine("Error! You entered a number less than 2");
                }
                else
                {
                    if (numberAsInt > 20)
                    {
                        Console.WriteLine("Error! You entered a number bigger than 20");
                    }
                    else
                    {
                        for (int i = 1; i <= numberAsInt; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            var result =  number * Factorial(number - 1);
            return result;
        }

        public static double FactorialNonRecursive(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }


        public static bool BinarySearch(int[] array, int numberToSearch, int min, int max)
        {
            if (min == max)
            {
                var value = array[min];
                var result = value == numberToSearch;
                return result;
            }

            var mediumIndex = (min + max) / 2;
            var mediumValue = array[mediumIndex];

            if (mediumValue > numberToSearch)
            {
                var result =  BinarySearch(array, numberToSearch, min, max = mediumIndex - 1);
                return result;
            }
            else if (mediumValue < numberToSearch)
            {
                var result = BinarySearch(array, numberToSearch, min = mediumIndex + 1, max);
                return result;
            }
            else
            {
                return true;
            }
        }

        public static bool BinarySearchNonRecursive(int[] array, int numberToSearch, int min, int max)
        {
            return true;
        }
    }

    public static class Utils 
    {
        public static bool BinarySearch(int[] array, int numberToSearch)
        {
            return true;
        }
    }
}
