
using Microsoft.Extensions.Configuration;
using System;

namespace ClassLibrary1.CommonClasses
{
    public class Helper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int Factorial(int number)
        {

            if (number < 0)
            {
                throw new Exception("Enter positive value !");
            }

            return number > 0 ? number * Factorial(--number) : 1;
        }
    }
}
