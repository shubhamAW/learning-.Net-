using System.Text;

namespace csharp_programming {
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Hello World,");
            Console.WriteLine("{0}", sb);
            sb.Append(" What a sunny day today!\n");
            Console.WriteLine("{0}", sb);
            sb.AppendFormat("It's {0}\u00b0 celsius temperature outside.", 40);
            sb.Replace("40", "104");
            sb.Remove(sb.ToString().IndexOf("celsius "), 7);
            sb.Insert(sb.ToString().IndexOf("temperature"), "fahrenheit ");
            string result = sb.ToString();
        }
    }
}