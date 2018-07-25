using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace UCSudoku
{
    public partial class row : UserControl
    {
        private int _activeCell;
        public row()
        {
            InitializeComponent();
        }

        #region properties
        /// <summary>
        /// activeCell - Set the active cell
        /// </summary>
        [Description("Set active cell before assigning a value"), Category("Sudoku")]
        public int activeCell
        {
            set
            {
                _activeCell = value;
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
                switch (_activeCell)
                {
                    case 0: cell1.fixedNumber = value; return;
                    case 1: cell2.fixedNumber = value; return;
                    case 2: cell3.fixedNumber = value; return;
                    case 3: cell4.fixedNumber = value; return;
                    case 4: cell5.fixedNumber = value; return;
                    case 5: cell6.fixedNumber = value; return;
                    case 6: cell7.fixedNumber = value; return;
                    case 7: cell8.fixedNumber = value; return;
                    case 8: cell9.fixedNumber = value; return;
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
                switch(_activeCell)
                {
                    case 0: cell1.possibleNumbers = value; return;
                    case 1: cell2.possibleNumbers = value; return;
                    case 2: cell3.possibleNumbers = value; return;
                    case 3: cell4.possibleNumbers = value; return;
                    case 4: cell5.possibleNumbers = value; return;
                    case 5: cell6.possibleNumbers = value; return;
                    case 6: cell7.possibleNumbers = value; return;
                    case 7: cell8.possibleNumbers = value; return;
                    case 8: cell9.possibleNumbers = value; return;
                    default: return;
                }
            }
        }
        #endregion
    }
}
