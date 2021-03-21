using MyJunkSolution.Displayers.Interfaces;

namespace MyJunkSolution.Waiters.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Waiter object.
    /// </summary>
    /// <remarks>
    /// Waiters wait for something interesting to happen.
    /// </remarks>
    public interface IWaiter
    {
        /// <summary>
        /// Associates this
        /// <see
        ///     cref="T:MyJunkSolution.Waiters.Interfaces.IWaiter" />
        /// with a
        /// <see
        ///     cref="T:MyJunkSolution.Displayers.Interfaces.IDisplayer" />
        /// to be
        /// used for displaying text to the user.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IWaiter AttachDisplayer(IDisplayer displayer);

        /// <summary>
        /// Delays the application until the user presses a key.
        /// </summary>
        void WaitForUserToPressAKey();

        /// <summary>
        /// Delays the application until the user presses a key.
        /// </summary>
        /// <param name="prompt">
        /// (Required.) String containing the prompt to display for the user.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="prompt" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        void WaitForUserToPressAKey(string prompt);
    }
}