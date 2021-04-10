using MyJunkSolution.Processors.Interfaces;

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
        ///     cref="T:MyJunkSolution.Processors.Interfaces.IProcessor" />
        /// to be
        /// used for displaying text to the user.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="displayer" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        IWaiter AttachProcessor(IProcessor displayer);

        /// <summary>
        /// Delays the application until the user presses a key.
        /// </summary>
        void WaitForUserToPressAKey();

        /// <summary>
        /// Delays the application until the user presses a key. Displays a
        /// <paramref name="prompt" /> to the user. A non-blank, non-whitespace
        /// value must be passed for the <paramref name="prompt" /> parameter.
        /// <para />
        /// If you do not want any text to be displayed, then call the overload
        /// of this method that takes no arguments.
        /// </summary>
        /// <param name="prompt">
        /// (Required.) String containing the prompt to display for the user.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="prompt" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the
        /// <see
        ///     cref="F:MyJunkSolution.Waiters.Waiter._displayer" />
        /// field has not
        /// been initialized, either by calling the appropriate constructor or
        /// by calling the
        /// <see
        ///     cref="M:MyJunkSolution.Waiters.Waiter.AttachProcessor" />
        /// method
        /// prior to calling this method.
        /// </exception>
        void WaitForUserToPressAKey(string prompt);
    }
}