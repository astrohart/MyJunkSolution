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
        /// Delays the application until the user presses a key.
        /// </summary>
        public void WaitForUserToPressAKey()
            => Console.ReadKey();
    }
}