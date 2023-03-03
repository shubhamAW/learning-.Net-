namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static void F(in Integer a) {
            a.value = 5;
        }

        static void G(in Integer a) {
            a = new Integer() { value = 10 };
        }

        static void Main() {
            Integer a = new Integer() { value = 1 };
            F(a);
            G(a);
        }
    }
}
