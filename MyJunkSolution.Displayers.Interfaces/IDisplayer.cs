namespace MyJunkSolution.Displayers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Displayer object.
    /// </summary>
    /// <remarks>
    /// Displayer objects print text on the screen.
    /// </remarks>
    public interface IDisplayer
    {
        /// <summary>
        /// Displays text for the user.
        /// </summary>
        void Display();

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
        void Display(string value);
    }
}