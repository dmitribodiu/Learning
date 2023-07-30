using System;

namespace Demo
{
    public static class Utils
    {
        //public static bool Oleg(this string text, int param)
        //{
        //    if (param == text.Length)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public static bool SearchNumber(this int[] array, int numberToSearch)
        {

            foreach (int number in array)
            {
                if (number == numberToSearch)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool SearchNumberFor(this int[] array, int numberToSearch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var element = array[i];
                if (element == numberToSearch)
                {
                    return true;
                }
            }

            return false;
        }

    }
}