using MyJunkSolution.Finders.Interfaces;

namespace MyJunkSolution.Finders.Factories
{
    public static class MakeNewFinder
    {
        public static IFinder FromScratch()
            => new Finder();
    }
}