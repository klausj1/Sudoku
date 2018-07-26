using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class CCell
    {
        public const int SIZE = 9;
        int fixedValue;
        List<int> possibleValues = null;
        int tryValue = 0;
        int tryIndex = -1;

        public CCell(int value)
        {
            fixedValue = value;
        }

        public CCell()
        {
            fixedValue = 0;
            if (SIZE == 9)
                possibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            else
                possibleValues = new List<int> { 1, 2, 3};
        }

        public List<int> getPossibleValues()
        {
            return possibleValues;
        }

        public int getFixedValue()
        {
            return fixedValue;
        }

        public bool isFixed()
        {
            return (fixedValue > 0);
        }

        internal void removePossibleValue(int fixedValue)
        {
            if (possibleValues != null)
                possibleValues.Remove(fixedValue);
        }

        internal bool ifPossibleSetToFixed()
        {
            if ((possibleValues != null) && (possibleValues.Count == 1))
            {
                fixedValue = possibleValues[0];
                possibleValues.Clear();
                return true;
            }
            else return false;
        }

        internal bool isValuePossible(int value)
        {
            return tryValue != value;
        }

        internal void resetValueToTry()
        {
            tryValue = 0;
            tryIndex = -1;
        }

        internal bool moveTryValueToFixedValue()
        {
            if (tryValue > 0)
            {
                fixedValue = tryValue;
                tryValue = 0;
                tryIndex = -1;
                return true;
            }
            return false;
        }

        internal int takeNextValue()
        {
            if (possibleValues == null) return 0;
            tryIndex++;
            if (tryIndex >= possibleValues.Count)
            {
                return 0;
            }
            else
            {
                tryValue = possibleValues[tryIndex];
                return tryValue;
            }
        }

    }
}