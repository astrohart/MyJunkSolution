using MyJunkSolution.Displayers.Factories;
using System;

namespace MyJunkSolution
{
    /// <summary>
    /// Provides global access to application-specific code.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        public static void Main()
        {
            MakeNewDisplayer.FromScratch()
                            .Dislpay();
            Console.ReadKey(); // wait for user to press a key
        }
    }
}