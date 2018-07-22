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
            field = new field_9x9("testfile.sudoku");
        }
    }
}
