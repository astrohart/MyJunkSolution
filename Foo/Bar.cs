using System;

namespace Foo
{
    public class Bar : IFoo
    {
        public void Baz()
            => Console.WriteLine(
                "Brian is a terrible software engineer!  But an awesome physicist!"
            );
    }
}