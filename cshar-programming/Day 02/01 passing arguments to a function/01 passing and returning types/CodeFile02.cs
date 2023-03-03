using System;

namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static Integer Add(Integer a, Integer b) {
            Integer c = new Integer {
                value = a.value + b.value
            };
            return c;
        }

        static void Main() {
            Integer u = new Integer() { value = 1 };
            Integer v = new Integer() { value = 2 };
            Integer result = Add(u, v);
            Console.WriteLine($"Sum of {u.value} and {v.value} is {result.value}");
        }
    }
}
