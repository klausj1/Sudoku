using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class field_9x9
    {
        cell[,] field = new cell[9,9];

        public field_9x9(string filename)
        {
            // c:\users\klaus\documents\visual studio 2015\Projects\Sudoku\Sudoku\bin\Debug\testfile.sudoku

            string[] rows = System.IO.File.ReadAllLines(@"..\..\testfile.sudoku");
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    int value;
                    bool ok = int.TryParse(rows[row][column].ToString(), out value);
                    if (ok)
                    {
                        field[row, column] = new cell(value);
                    }
                    else
                    {
                        field[row, column] = new cell();
                    }
                }
            }
        }
    }
}
