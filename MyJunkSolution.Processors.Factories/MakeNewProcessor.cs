using MyJunkSolution.Processors.Interfaces;

namespace MyJunkSolution.Processors.Factories
{
    /// <summary>
    /// Creates and initializes new instances of objects that implement the <see
    /// cref="T:MyJunkSolution.Processors.Interfaces.IProcessor"/> interface.
    /// </summary>
    public static class MakeNewProcessor
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see
        /// cref="T:MyJunkSolution.Processors.Interfaces.IProcessor"/> interface
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MyJunkSolution.Processors.Interfaces.IProcessor"/> interface.
        /// </returns>
        public static IProcessor FromScratch()
        => new Processor();
    }
}