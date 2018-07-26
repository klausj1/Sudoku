namespace Sudoku
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_init = new System.Windows.Forms.Button();
            this.grid1 = new UCSudoku.grid();
            this.tb_solve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_solve = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pb_init
            // 
            this.pb_init.Location = new System.Drawing.Point(721, 15);
            this.pb_init.Margin = new System.Windows.Forms.Padding(4);
            this.pb_init.Name = "pb_init";
            this.pb_init.Size = new System.Drawing.Size(100, 28);
            this.pb_init.TabIndex = 0;
            this.pb_init.Text = "Read File";
            this.pb_init.UseVisualStyleBackColor = true;
            this.pb_init.Click += new System.EventHandler(this.pb_init_Click);
            // 
            // grid1
            // 
            this.grid1.Location = new System.Drawing.Point(34, 74);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(521, 531);
            this.grid1.TabIndex = 1;
            // 
            // tb_solve
            // 
            this.tb_solve.Location = new System.Drawing.Point(650, 74);
            this.tb_solve.Name = "tb_solve";
            this.tb_solve.Size = new System.Drawing.Size(171, 35);
            this.tb_solve.TabIndex = 2;
            this.tb_solve.Text = "ReducePossibleValues";
            this.tb_solve.UseVisualStyleBackColor = true;
            this.tb_solve.Click += new System.EventHandler(this.tb_solve_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "FindFixedCells";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_solve
            // 
            this.pb_solve.Location = new System.Drawing.Point(650, 203);
            this.pb_solve.Name = "pb_solve";
            this.pb_solve.Size = new System.Drawing.Size(171, 35);
            this.pb_solve.TabIndex = 4;
            this.pb_solve.Text = "Solve";
            this.pb_solve.UseVisualStyleBackColor = true;
            this.pb_solve.Click += new System.EventHandler(this.pb_solve_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(34, 628);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(521, 22);
            this.tb_result.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 725);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.pb_solve);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_solve);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.pb_init);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pb_init;
        private UCSudoku.grid grid1;
        private System.Windows.Forms.Button tb_solve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pb_solve;
        private System.Windows.Forms.TextBox tb_result;
    }
}

