using System.Diagnostics;

namespace csharp_programming {
    class Math {
        public static double PI { get { return 3.1428; } } //here we ommitted the set. so it become a read only
    }

    class Program {
        static void Main() {
            double pi = Math.PI;
        }
    }
}