using System;

namespace MyFirstMethod
{
    /// <summary>
    /// This is our project´s main class
    /// </summary>
    class Program
    {
        /// <summary>
        /// This program Main method, The program starts here
        /// </summary>
        /// <param name="args">Not used in this program</param>
        static void Main(string[] args)
        {
            CountToN(3);
            CountTo10();
        }
        /// <summary>
        /// This method prints numbers from 1 to 10
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }
        /// <summary>
        /// This method will print numbers from 1 to <see cref="n"/> 
        /// </summary>
        /// <param name="n">Maximum number to print</param>
        static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
