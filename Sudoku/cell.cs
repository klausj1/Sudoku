using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class cell
    {
        int fixedValue;
        List<int> possibleValues = null;

        public cell(int value)
        {
            fixedValue = value;
        }

        public cell()
        {
            fixedValue = 0;
            possibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public List<int> getPossibleValues()
        {
            return possibleValues;
        }

        public int getFixedValue()
        {
            return fixedValue;
        }
    }
}