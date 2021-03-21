using System;

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
        /// Delays the application until the user presses a key.
        /// </summary>
        void WaitForUserToPressAKey();
    }

    /// <summary>
    /// Implements delays for the application.
    /// </summary>
    public class Waiter : IWaiter
    {
        /// <summary>
        /// Delays the application until the user presses a key.
        /// </summary>
        public void WaitForUserToPressAKey()
            => Console.ReadKey();
    }
}