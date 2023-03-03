namespace csharp_programming {
    class Integer {
        public double Value { get; 
            set; }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.Value = 1.11;
            double n = i.Value;
        }
    }
}