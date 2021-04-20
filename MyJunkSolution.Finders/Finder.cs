using MyJunkSolution.Finders.Interfaces;
using System;

namespace MyJunkSolution.Finders
{
    /// <summary>
    /// Finds some text in a data file, or some such other.
    /// </summary>
    public class Finder : IFinder
    {
        /// <summary>
        /// Finds the text.
        /// </summary>
        public void Find()
            => Console.WriteLine(
                "Hello, world!  The text has been found."
            );
    }
}