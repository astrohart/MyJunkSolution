namespace MyJunkSolution.Finders.Interfaces
{
    public static class GetFinder
    {
        public static IFinder MakeNewInstance()
            => new Bar();
    }
}