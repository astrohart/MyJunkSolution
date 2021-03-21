using System;

namespace FizzBuzz
{
    public class Bar : IFizzBuzz
    {
        public void Baz()
            => Console.WriteLine(
                "Brian is a terrible software engineer!  But an awesome physicist!"
            );
    }
}