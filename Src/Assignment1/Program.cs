﻿using System;
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
            Console.ReadKey();
        }
    }
}