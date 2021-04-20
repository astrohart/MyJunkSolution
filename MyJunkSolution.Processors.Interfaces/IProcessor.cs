namespace MyJunkSolution.Processors.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Processor object.
    /// </summary>
    /// <remarks>
    /// Processor objects print text on the screen.
    /// </remarks>
    public interface IProcessor
    {
        /// <summary>
        /// Processes text for the user.
        /// </summary>
        void Process();

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
        void Process(string value);
    }
}