using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UCSudoku
{
    public partial class grid : UserControl
    {
        private int _activeRow;
        private int _activeColumn;
        public grid()
        {
            InitializeComponent();
        }
        #region properties
        /// <summary>
        /// activeCell - Set the active row
        /// </summary>
        [Description("Set active row before assigning a value"), Category("Sudoku")]
        public int activeRow
        {
            set
            {
                _activeRow = value;
            }
        }

        /// <summary>
        /// activeCell - Set the active column
        /// </summary>
        [Description("Set active column before assigning a value"), Category("Sudoku")]
        public int activeColumn
        {
            set
            {
                _activeColumn = value;
            }
        }

        /// <summary>
        /// fixedNumber - Set this value if the cell already contains a fixed value
        /// </summary>
        [Description("Set this value if the cell already contains a fixed value"), Category("Sudoku")]
        public int fixedNumber
        {
            set
            {
                switch (_activeRow)
                {
                    case 0: row1.activeCell = _activeColumn; row1.fixedNumber = value; return;
                    case 1: row2.activeCell = _activeColumn; row2.fixedNumber = value; return;
                    case 2: row3.activeCell = _activeColumn; row3.fixedNumber = value; return;
                    case 3: row4.activeCell = _activeColumn; row4.fixedNumber = value; return;
                    case 4: row5.activeCell = _activeColumn; row5.fixedNumber = value; return;
                    case 5: row6.activeCell = _activeColumn; row6.fixedNumber = value; return;
                    case 6: row7.activeCell = _activeColumn; row7.fixedNumber = value; return;
                    case 7: row8.activeCell = _activeColumn; row8.fixedNumber = value; return;
                    case 8: row9.activeCell = _activeColumn; row9.fixedNumber = value; return;
                    default: return;
                }
            }
        }

        /// <summary>
        /// possibleNumbers
        /// </summary>
        [Description("Set this list to show the list of values which are still possible"), Category("Sudoku")]
        public List<int> possibleNumbers
        {
            set
            {
                switch (_activeRow)
                {
                    case 0: row1.activeCell = _activeColumn; row1.possibleNumbers = value; return;
                    case 1: row2.activeCell = _activeColumn; row2.possibleNumbers = value; return;
                    case 2: row3.activeCell = _activeColumn; row3.possibleNumbers = value; return;
                    case 3: row4.activeCell = _activeColumn; row4.possibleNumbers = value; return;
                    case 4: row5.activeCell = _activeColumn; row5.possibleNumbers = value; return;
                    case 5: row6.activeCell = _activeColumn; row6.possibleNumbers = value; return;
                    case 6: row7.activeCell = _activeColumn; row7.possibleNumbers = value; return;
                    case 7: row8.activeCell = _activeColumn; row8.possibleNumbers = value; return;
                    case 8: row9.activeCell = _activeColumn; row9.possibleNumbers = value; return;
                    default: return;
                }
            }
        }
        #endregion
    }
}