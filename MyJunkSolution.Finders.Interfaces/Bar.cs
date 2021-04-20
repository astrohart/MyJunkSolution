using System;

namespace MyJunkSolution.Finders.Interfaces
{
    public class Bar : IFinder
    {
        public void Find()
            => Console.WriteLine(
                "Brian is a terrible software engineer!  But an awesome physicist!"
            );
    }
}