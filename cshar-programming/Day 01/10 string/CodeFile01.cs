using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            string text = @"Hello,
                            World!";
            Console.WriteLine("text = {0}", text);

            string s = "Hello\r\nWorld!\a"; //\a is bell sound
            Console.WriteLine(s); 

            s = "C:\\Windows\\System\\";
            Console.WriteLine(s);

            // SELECT * FROM ADDRESSES WHERE NAME="Jose"
            string sName = "Jose";
            s = "SELECT * FROM ADDRESSES WHERE NAME=\""
                + sName
                + "\"";
            Console.WriteLine(s);

            //accessing specific character in a string
            string myString = "A string";
            char myChar = myString[2];
            Console.WriteLine(myChar);

            //getting string as array of characters
            char[] myChars = myString.ToCharArray();
            foreach (char character in myString) {
                Console.WriteLine("{0}", character);
            }

            //calculating string length
            myString = Console.ReadLine();
            Console.WriteLine("You typed {0} characters.", myString.Length);

            //converting all characters to lowercase
            Console.WriteLine(myString.ToLower()); // original string doen't get affected..

            myString = "       " + myString +  "              ";

            //triming
            Console.WriteLine("[" + myString + "]");
            Console.WriteLine("[" + myString.TrimStart() + "]");
            Console.WriteLine("[" + myString.TrimEnd() + "]");
            Console.WriteLine("[" + myString.Trim() + "]");

            //padding
            myString = myString.PadLeft(50, '-');
            Console.WriteLine(myString);

            char[] trimChars = { ' ', 'h', 'd', 'o' };
            string userResponse = Console.ReadLine();
            userResponse = userResponse.ToLower();
            userResponse = userResponse.Trim(trimChars);
            Console.WriteLine(userResponse);
        }
    }
}