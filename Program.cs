using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(20));
        }

        static long factorial(long val)
        {
            if (val > 1)
            {
                return val*factorial(val - 1);
            }
            return val;
        }
    }
}
