using MyJunkSolution.Displayers.Interfaces;
using MyJunkSolution.Displayers.Properties;
using System;

namespace MyJunkSolution.Displayers
{
    /// <summary>
    /// Displays text on the screen.
    /// </summary>
    public class Displayer : IDisplayer
    {
        /// <summary>
        /// Displays text for the user.
        /// </summary>
        public void Display()
            => Console.WriteLine(Resources.TextToDisplay);

        /// <summary>
        /// Displays text for the user.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the text to be displayed on the console.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public void Display(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            Console.WriteLine(value);
        }
    }
}