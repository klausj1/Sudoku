using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class MainForm : Form
    {
        field_9x9 field = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void pb_init_Click(object sender, EventArgs e)
        {
            cell myCell = null;
            field = new field_9x9("testfile.sudoku");
            int fixedValue = 0;
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    myCell = field.getCell(row, column);
                    grid1.activeColumn = column;
                    grid1.activeRow = row;
                    fixedValue = myCell.getFixedValue();
                    if (fixedValue > 0)
                    {
                        grid1.fixedNumber = fixedValue;
                    }
                    else
                    {
                        grid1.possibleNumbers = myCell.getPossibleValues();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
