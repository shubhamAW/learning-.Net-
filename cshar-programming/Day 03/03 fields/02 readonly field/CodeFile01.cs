namespace csharp_programming {
    class Integer {
        public readonly int value;
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.value = 1;
            int n = i.value;
        }
    }
}