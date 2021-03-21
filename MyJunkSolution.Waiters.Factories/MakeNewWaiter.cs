using MyJunkSolution.Waiters.Interfaces;

namespace MyJunkSolution.Waiters.Factories
{
    /// <summary>
    /// Creates and initializes new instances of objects that implement the
    /// <see
    ///     cref="T:MyJunkSolution.Waiters.Interfaces.IWaiter" />
    /// interface.
    /// </summary>
    public static class MakeNewWaiter
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MyJunkSolution.Waiters.Interfaces.IWaiter" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MyJunkSolution.Waiters.Interfaces.IWaiter" />
        /// interface.
        /// </returns>
        public static IWaiter FromScratch()
            => new Waiter();
    }
}