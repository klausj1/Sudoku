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
    /// <summary>
    /// Explain Summary here
    /// </summary>
    public partial class cell : UserControl
    {
        /// <summary>
        /// Explain Summary here
        /// </summary>
        public cell()
        {
            InitializeComponent();
        }

        #region properties
        /// <summary>
        /// fixedNumber - Set this value if the cell already contains a fixed value
        /// </summary>
        [Description("Set this value if the cell already contains a fixed value"), Category("Sudoku")]
        public int fixedNumber
        {
            set
            {
                tb_number.Text = value.ToString();
                tb_number.Visible = true;
                tb_possibleNumbers.Visible = false;
                tb_number.BackColor = Color.Black;
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
                tb_possibleNumbers.Text = String.Join("", value);
                tb_number.Visible = false;
                tb_possibleNumbers.Visible = true;
                int rgb = 115 + value.Count*13;
                tb_possibleNumbers.BackColor = Color.FromArgb(rgb, rgb, rgb);
                // ToDo: Set Backgroundcolor depending on number of possible values
            }
        }
        #endregion
    }
}
