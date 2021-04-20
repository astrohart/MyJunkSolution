using MyJunkSolution.Finders.Interfaces;

namespace MyJunkSolution.Finders.Factories
{
    public static class GetFinder
    {
        public static IFinder MakeNewInstance()
            => new Finder();
    }
}