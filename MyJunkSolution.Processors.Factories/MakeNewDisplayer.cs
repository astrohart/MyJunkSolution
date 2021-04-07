using MyJunkSolution.Processors.Interfaces;
using MyJunkSolution.Processors;

namespace MyJunkSolution.Processors.Factories
{
    /// <summary>
    /// Creates and initializes new instances of objects that implement the
    /// <see
    ///     cref="T:MyJunkSolution.Processors.Interfaces.IDisplayer" />
    /// interface.
    /// </summary>
    public static class MakeNewDisplayer
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MyJunkSolution.Processors.Interfaces.IDisplayer" />
        /// interface
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MyJunkSolution.Processors.Interfaces.IDisplayer" />
        /// interface.
        /// </returns>
        public static IDisplayer FromScratch()
            => new Displayer();
    }
}