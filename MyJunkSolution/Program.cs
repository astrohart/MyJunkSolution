using MyJunkSolution.Displayers.Factories;
using MyJunkSolution.Properties;
using MyJunkSolution.Waiters.Factories;

namespace MyJunkSolution
{
    /// <summary>
    /// Provides global access to application-specific code.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        public static void Main()
        {
            var newDisplayer = MakeNewDisplayer.FromScratch();
            newDisplayer.Display();

            Foo.Foo.Bar()
               .Baz();

            // wait for the user to press a key, so that the user can verify the
            // displayed text.
            MakeNewWaiter.FromScratch()
                         .AttachDisplayer(newDisplayer)
                         .WaitForUserToPressAKey(Resources.Message_PressAnyKeyToContinue);
        }
    }
}