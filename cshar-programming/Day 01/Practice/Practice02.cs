using System;


namespace cshar_programming
{
    internal class Practice02
    {
        public static void Main(string[] args)
        {
            string input;
            Console.Write("Enter Temperature to be wanted to Converted: ");
            input = Console.ReadLine();
            double temp = Convert.ToDouble(input);

            Console.Write("Please enter desire conversion for celcius type 'c' & for farenheit type 'f'");
            input = Console.ReadLine();
            char ch = Convert.ToChar(input);

            double result = 0.0;

            switch (ch)
            {
                case 'c':
                    result = (temp - 32) * 5 / 9;
                    Console.WriteLine("Conversion From Fahrenheit to Celcius is {0} ", result);
                    break;
                case 'f':
                    result = ((temp* 9) / 5) + 32;
                    Console.WriteLine("Conversion from celcius to Fahrenheit is {0}", result);
                    break;
                default:
                    Console.WriteLine("Please Enter valid selections: ");
                    break;
            }


        }
    }
}
