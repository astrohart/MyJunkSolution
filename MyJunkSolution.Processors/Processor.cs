using MyJunkSolution.Processors.Interfaces;
using MyJunkSolution.Processors.Properties;
using System;

namespace MyJunkSolution.Processors
{
    /// <summary>
    /// Processes text on the screen.
    /// </summary>
    public class Processor : IProcessor
    {
        /// <summary>
        /// Processes text for the user.
        /// </summary>
        public void Process()
            => Console.WriteLine(Resources.TextToProcess);

        /// <summary>
        /// Processes text for the user.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the text to be displayed on the console.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public void Process(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            Console.WriteLine(value);
        }
    }
}