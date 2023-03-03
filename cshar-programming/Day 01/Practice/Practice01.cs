using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshar_programming
{
    internal class Practice01
    {
        public static void Main()
        {
            string str;
            Console.Write("Enter a String: ");
            str= Console.ReadLine();

            int left = 0;
            int right = str.Length-1;

            bool is_palindrome = true;

            while(left < right)
            {
                if (str[left] != str[right])
                {
                    is_palindrome = false;
                    break;
                }
                    
                left++;
                right--;
            }

            if (is_palindrome)
            {
                Console.WriteLine("Given String is Palindrome");
            }
            else
            {
                Console.WriteLine("Given String is Not Palindrome");
            }
        }
    }
}
