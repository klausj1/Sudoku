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
            this.SuspendLayout();
            // 
            // pb_init
            // 
            this.pb_init.Location = new System.Drawing.Point(721, 15);
            this.pb_init.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 725);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.pb_init);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pb_init;
        private UCSudoku.grid grid1;
    }
}

