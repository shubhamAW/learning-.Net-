using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            double d = 000.234;
            Console.WriteLine("{0:#.000}", d);
        }
    }
}

/*
 * Refer https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
 * for custom numeric format strings.
 */