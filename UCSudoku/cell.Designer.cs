namespace UCSudoku
{
    partial class cell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_possibleNumbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_number
            // 
            this.tb_number.BackColor = System.Drawing.Color.Black;
            this.tb_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_number.Font = new System.Drawing.Font("Courier New", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_number.ForeColor = System.Drawing.Color.White;
            this.tb_number.Location = new System.Drawing.Point(0, 0);
            this.tb_number.MaxLength = 1;
            this.tb_number.Multiline = true;
            this.tb_number.Name = "tb_number";
            this.tb_number.ReadOnly = true;
            this.tb_number.Size = new System.Drawing.Size(60, 60);
            this.tb_number.TabIndex = 1;
            this.tb_number.TabStop = false;
            this.tb_number.Text = "1";
            this.tb_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_number.Visible = false;
            // 
            // tb_possibleNumbers
            // 
            this.tb_possibleNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tb_possibleNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_possibleNumbers.Enabled = false;
            this.tb_possibleNumbers.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_possibleNumbers.Location = new System.Drawing.Point(0, 0);
            this.tb_possibleNumbers.Margin = new System.Windows.Forms.Padding(0);
            this.tb_possibleNumbers.MaxLength = 10;
            this.tb_possibleNumbers.Multiline = true;
            this.tb_possibleNumbers.Name = "tb_possibleNumbers";
            this.tb_possibleNumbers.ReadOnly = true;
            this.tb_possibleNumbers.Size = new System.Drawing.Size(60, 60);
            this.tb_possibleNumbers.TabIndex = 2;
            this.tb_possibleNumbers.TabStop = false;
            this.tb_possibleNumbers.Text = "123456789";
            // 
            // cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tb_possibleNumbers);
            this.Controls.Add(this.tb_number);
            this.Name = "cell";
            this.Size = new System.Drawing.Size(58, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_possibleNumbers;
    }
}
