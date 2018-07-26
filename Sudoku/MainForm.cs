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
        CGrid grid = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void pb_init_Click(object sender, EventArgs e)
        {
            grid = new CGrid("wikipedia.sudoku");
            //grid = new CGrid("testfile.sudoku");
            //grid = new CGrid("3x3.sudoku");
            updateGrid();
        }

        private void updateGrid()
        {
            CCell currentCell = null;
            for (int row = 0; row < CCell.SIZE; row++)
            {
                for (int column = 0; column < CCell.SIZE; column++)
                {
                    currentCell = grid.getCell(row, column);
                    grid1.activeColumn = column;
                    grid1.activeRow = row;
                    if (currentCell.isFixed())
                    {
                        grid1.fixedNumber = currentCell.getFixedValue();
                    }
                    else
                    {
                        grid1.possibleNumbers = currentCell.getPossibleValues();
                    }
                }
            }

        }

        private void tb_solve_Click(object sender, EventArgs e)
        {
            grid.reducePossibleValues();
            updateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid.findFixedCells();
            updateGrid();
        }

        private void pb_solve_Click(object sender, EventArgs e)
        {
            // ToDo: Show progress!

            bool ok = grid.solve();
            if (ok)
            {
                tb_result.Text = "Hurrah, Sudoku solved!!!";
                updateGrid();
            }
            else
                tb_result.Text = "Sudoku could not be solved :( :( :( :( ";
        }
    }
}
