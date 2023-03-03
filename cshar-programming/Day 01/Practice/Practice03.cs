using System;
using System.Data;

namespace cshar_programming
{
    internal class Practice03
    {
        public static void Main()
        {
            string input;
            Console.WriteLine("Please enter Desire depth of pascal triangle");
            input = Console.ReadLine();
            int depth = Convert.ToInt32(input);

            int[][] triangle = new int[depth][];

            for (int i = 0; i < depth; i++)
            {
                triangle[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        triangle[i][j] = 1;
                    }
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
