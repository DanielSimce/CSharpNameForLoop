using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_Bukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 100; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && column > 1 && column < 5) || (column == 5 && row != 0 && row != 6) ||
                        (column == 8 || column == 13) || ((row == 0 || row == 3) && column > 8 && column < 13) ||
                        column == 16 || column == 21 || (column == 17 && row == 1) || (column == 18 && row == 2) || (column == 19 && row == 4) || (column == 19 && row == 3) || (column == 20 && row == 5) ||
                        column == 26 ||
                        column == 31 || (row == 0 && column > 31 && column < 36) || (row == 3 && column > 31 && column < 35) || (row == 6 && column > 31 && column < 36) ||
                        column == 39 || (row == 6 && column > 39 && column < 45))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.ReadLine();
        }
    }
}
