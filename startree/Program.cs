using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < ((9 - i) * 2 - 1) / 2; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < (i+1) * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
