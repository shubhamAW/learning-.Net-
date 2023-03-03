namespace csharp_programming {
    class Integer {
        public readonly int value = 1;

        public Integer() {
            value = 5;
        }

        public void SetValue(int value) {
            this.value = value;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            int n = i.value;
        }
    }
}

/*
 * A field defined with ‘readonly’ modifier is readonly inside as well.
 */