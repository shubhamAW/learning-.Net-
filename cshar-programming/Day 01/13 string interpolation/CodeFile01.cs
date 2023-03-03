using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            int i = 940;
            int j = 73;
            // Console.WriteLine(" {0,4}\n+{1,4}\n — — \n {2,4}", i, j, i + j);
            Console.WriteLine($" {i,4}\n+{j,4}\n — — \n {i + j,4}");
        }
    }
}