using MyJunkSolution.Processors.Interfaces;
using MyJunkSolution.Waiters.Interfaces;
using System;

namespace MyJunkSolution.Waiters
{
    /// <summary>
    /// Implements delays for the application.
    /// </summary>
    public class Waiter : IWaiter
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MyJunkSolution.Processors.Interfaces.IDisplayer" />
        /// interface.
        /// </summary>
        private IDisplayer _displayer;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MyJunkSolution.Waiters.Waiter" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="displayer">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MyJunkSolution.Processors.Interfaces.IDisplayer" />
        /// interface for the purposes of, e.g., displaying user prompts.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="displayer" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public Waiter(IDisplayer displayer)
            => _displayer = displayer ??
                            throw new ArgumentNullException(nameof(displayer));

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MyJunkSolution.Waiters.Waiter" />
        /// and returns a reference to it.
        /// </summary>
        public Waiter()
            => _displayer = null;

        /// <summary>
        /// Associates this
        /// <see
        ///     cref="T:MyJunkSolution.Waiters.Interfaces.IWaiter" />
        /// with a
        /// <see
        ///     cref="T:MyJunkSolution.Processors.Interfaces.IDisplayer" />
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
        public IWaiter AttachDisplayer(IDisplayer displayer)
        {
            _displayer = displayer ??
                         throw new ArgumentNullException(nameof(displayer));

            return this;
        }

        /// <summary>
        /// Delays the application until the user presses a key.
        /// </summary>
        public void WaitForUserToPressAKey()
            => Console.ReadKey();

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
        ///     cref="M:MyJunkSolution.Waiters.Waiter.AttachDisplayer" />
        /// method
        /// prior to calling this method.
        /// </exception>
        public void WaitForUserToPressAKey(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(prompt)
                );
            if (_displayer == null)
                throw new InvalidOperationException(
                    "The displayer object dependency has not been initialized."
                );
            _displayer.Display(prompt);
            WaitForUserToPressAKey();  
        }
    }
}