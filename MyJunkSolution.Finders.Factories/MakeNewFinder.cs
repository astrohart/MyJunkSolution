using MyJunkSolution.Finders.Interfaces;

namespace MyJunkSolution.Finders.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MyJunkSolution.Finders.Interfaces.IFinder" />
    /// interface.
    /// </summary>
    public static class MakeNewFinder
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MyJunkSolution.Finders.Interfaces.IFinder" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MyJunkSolution.Finders.Interfaces.IFinder" />
        /// interface.
        /// </returns>
        public static IFinder FromScratch()
            => new Finder();
    }
}