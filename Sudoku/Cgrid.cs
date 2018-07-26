using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class CGrid
    {
        private CCell[,] cells = new CCell[CCell.SIZE, CCell.SIZE];
        private int numNotFixed = CCell.SIZE * CCell.SIZE;


        public CGrid(string filename)
        {
            // c:\users\klaus\documents\visual studio 2015\Projects\Sudoku\Sudoku\bin\Debug\testfile.sudoku

            string[] rows = System.IO.File.ReadAllLines(@"..\..\" + filename);
            for (int row = 0; row < CCell.SIZE; row++)
            {
                for (int column = 0; column < CCell.SIZE; column++)
                {
                    int value;
                    bool ok = int.TryParse(rows[row][column].ToString(), out value);
                    if (ok)
                    {
                        cells[row, column] = new CCell(value);
                        numNotFixed--;
                    }
                    else
                    {
                        cells[row, column] = new CCell();
                    }
                }
            }
        }

        public CCell getCell(int row, int column)
        {
            return cells[row, column];
        }

        public void reducePossibleValues()
        {
            for (int row = 0; row < CCell.SIZE; row++)
            {
                for (int column = 0; column < CCell.SIZE; column++)
                {
                    if (cells[row, column].isFixed())
                    {
                        removePossibleValues(row, column, cells[row, column].getFixedValue());
                    }

                }
            }
        }

        internal void findFixedCells()
        {
            for (int row = 0; row < CCell.SIZE; row++)
            {
                for (int column = 0; column < CCell.SIZE; column++)
                {
                    if (cells[row, column].ifPossibleSetToFixed()) // ToDo: Check if values are possible against all other fixed values
                        numNotFixed--;
                }
            }
        }

        internal bool solve()
        {
            // Prerequisite: Possible values do NOT contain values which violate fixed values, so reducePossibleValues has been called before
            int currentTryRow = 0, currentTryColumn = -1, tryValue = 1;
            bool isLastTryCell = false, isfirstTryCell = false; int count = 0;

            isLastTryCell = takeNextTryCell(ref currentTryRow, ref currentTryColumn);
            tryValue = cells[currentTryRow, currentTryColumn].takeNextValue();
            if (tryValue == 0)
                return false; // should never happen!

            while (!isLastTryCell && !isfirstTryCell) // loop for all cells and all values
            {
                count++;
                if (isValuePossible(currentTryRow, currentTryColumn, tryValue))
                {
                    isLastTryCell = takeNextTryCell(ref currentTryRow, ref currentTryColumn);
                    if (!isLastTryCell)
                    {
                        while (!isLastTryCell && cells[currentTryRow, currentTryColumn].isFixed()) // ToDo: Like above, do this better
                        {
                            isLastTryCell = takeNextTryCell(ref currentTryRow, ref currentTryColumn);
                        }
                        if (!isLastTryCell)
                        {
                            tryValue = cells[currentTryRow, currentTryColumn].takeNextValue();
                            if (tryValue == 0)
                                return false; // should never happen!
                        }
                    }
                }
                else
                {
                    tryValue = cells[currentTryRow, currentTryColumn].takeNextValue();
                    while ((tryValue == 0) && !isfirstTryCell && !isLastTryCell) // Did not find a possible value
                    {
                        cells[currentTryRow, currentTryColumn].resetValueToTry();
                        isfirstTryCell = takePreviousTryCell(ref currentTryRow, ref currentTryColumn);
                        tryValue = cells[currentTryRow, currentTryColumn].takeNextValue();
                    }
                }
            }

            if (isLastTryCell) // solved!!
            {
                moveTryValuesToFixedValues();
                return true;
            }
            else
                return false;
        }


        private bool isValuePossible(int currentTryRow, int currentTryColumn, int value)
        {
            if (value == 0)
                return false;

            for (int row = 0; row < CCell.SIZE; row++)
            {
                if ((row != currentTryRow) && !cells[row, currentTryColumn].isFixed())
                {
                    if (!(cells[row, currentTryColumn].isValuePossible(value)))
                        return false;
                }
            }

            for (int column = 0; column < CCell.SIZE; column++)
            {
                if ((column != currentTryColumn) && !cells[currentTryRow, column].isFixed())
                {
                    if (!(cells[currentTryRow, column].isValuePossible(value)))
                        return false;
                }
            }

            // Check Quadrants
            int beginColumn = 0, beginRow = 0;
            switch (currentTryRow)
            {
                case 0: case 1: case 2: beginRow = 0; break;
                case 3: case 4: case 5: beginRow = 3; break;
                case 6: case 7: case 8: beginRow = 6; break;
                default: beginRow = 0; break;
            }
            switch (currentTryColumn)
            {
                case 0: case 1: case 2: beginColumn = 0; break;
                case 3: case 4: case 5: beginColumn = 3; break;
                case 6: case 7: case 8: beginColumn = 6; break;
                default: beginColumn = 0; break;
            }
            for (int row = beginRow; row < beginRow + 3; row++)
            {
                for (int column = beginColumn; column < beginColumn + 3; column++)
                {
                    if (!((column == currentTryColumn) && (row == currentTryRow)) && !cells[row, column].isFixed())
                    {
                        if (!(cells[row, column].isValuePossible(value)))
                            return false;
                    }
                }
            }

            return true;
        }

        private bool takeNextTryCell(ref int currentTryRow, ref int currentTryColumn)
        {
            do
            {
                if (currentTryColumn == CCell.SIZE - 1)
                {
                    if (currentTryRow == CCell.SIZE - 1)
                    {
                        return true;
                    }
                    else
                    {
                        currentTryRow++; currentTryColumn = 0;
                    }
                }
                else
                {
                    currentTryColumn++;
                }
            }
            while (cells[currentTryRow, currentTryColumn].isFixed());
            return false;
        }
        private bool takePreviousTryCell(ref int currentTryRow, ref int currentTryColumn)
        {
            do
            {
                if (currentTryColumn == 0)
                {
                    if (currentTryRow == 0)
                    {
                        return true;
                    }
                    else
                    {
                        currentTryRow--; currentTryColumn = CCell.SIZE-1;
                    }
                }
                else
                {
                    currentTryColumn--;
                }
            }
            while (cells[currentTryRow, currentTryColumn].isFixed());
            return false;
        }

        private void removePossibleValues(int currentRow, int currentColumn, int fixedValue)
        {
            for (int row = 0; row < CCell.SIZE; row++)
            {
                if (row != currentRow)
                {
                    cells[row, currentColumn].removePossibleValue(fixedValue);
                }
            }
            for (int column = 0; column < CCell.SIZE; column++)
            {
                if (column != currentColumn)
                {
                    cells[currentRow, column].removePossibleValue(fixedValue);
                }
            }
            int beginColumn = 0, beginRow = 0;
            switch (currentRow)
            {
                case 0: case 1: case 2: beginRow = 0; break;
                case 3: case 4: case 5: beginRow = 3; break;
                case 6: case 7: case 8: beginRow = 6; break;
                default: beginRow = 0; break;
            }
            switch (currentColumn)
            {
                case 0: case 1: case 2: beginColumn = 0; break;
                case 3: case 4: case 5: beginColumn = 3; break;
                case 6: case 7: case 8: beginColumn = 6; break;
                default: beginColumn = 0; break;
            }
            for (int row = beginRow; row < beginRow + 3; row++)
            {
                for (int column = beginColumn; column < beginColumn + 3; column++)
                {
                    if (!((column == currentColumn) && (row == currentRow)))
                    {
                        cells[row, column].removePossibleValue(fixedValue);
                    }
                }
            }
        }
        private void moveTryValuesToFixedValues()
        {
            for (int row = 0; row < CCell.SIZE; row++)
            {
                for (int column = 0; column < CCell.SIZE; column++)
                {
                    if (cells[row, column].moveTryValueToFixedValue())
                        numNotFixed--;
                }
            }
        }

    } // class Cgrid
}
