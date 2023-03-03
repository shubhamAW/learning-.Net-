namespace csharp_programming {
    class Integer {
        int value;
        public int Value {
            get { return value; }
            set { this.value = value; }
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.Value = 1;
            int n = i.Value;
        }
    }
}
