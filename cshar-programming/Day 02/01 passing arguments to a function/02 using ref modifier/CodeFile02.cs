using System;

namespace csharp_programming {
    class Program {
        static void Swap(ref int a, ref int b) {
            int c = a;
            a = b;
            b = c;
        }

        static void Main() {
            int a = 1, b = 2;
            Swap(ref a, ref b);
        }
    }
}

/*
 * An argument that is passed to a ref parameter must be initialized/assignedS before it's passed. 
 * Within the function, assigning to the ref parameter is optional.
 * 
 */