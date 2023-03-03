namespace csharp_programming {
    class Program {
        static void Main() {
            bool result = false;
            string s = "3.14";

            double d = 0.0;
            result = double.TryParse(s, out d);

            int i = 0;
            result = int.TryParse(s, out i);
        }
    }
}

/*
 * - If string is not in valid form, TryParse doesn't throw exception.
 */
