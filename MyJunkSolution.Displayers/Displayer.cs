using MyJunkSolution.Displayers.Interfaces;
using MyJunkSolution.Displayers.Properties;
using System;

namespace MyJunkSolution.Displayers
{
    /// <summary>
    /// Displays text on the screen.
    /// </summary>
    public class Displayer : IDisplayer
    {
        /// <summary>
        /// Displays text for the user.
        /// </summary>
        public void Dislpay()
            => Console.WriteLine(Resources.TextToDisplay);
    }
}