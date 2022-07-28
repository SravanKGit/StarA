using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows\n");
            var number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
