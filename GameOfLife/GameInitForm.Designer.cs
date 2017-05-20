namespace GameOfLife
{
    partial class GameInitForm
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
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnGenerateCells = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(221, 23);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 0;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(51, 26);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(160, 13);
            this.lblRow.TabIndex = 1;
            this.lblRow.Text = "How many rows in the universe?";
            // 
            // btnGenerateCells
            // 
            this.btnGenerateCells.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerateCells.Location = new System.Drawing.Point(167, 115);
            this.btnGenerateCells.Name = "btnGenerateCells";
            this.btnGenerateCells.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateCells.TabIndex = 2;
            this.btnGenerateCells.Text = "Start Game";
            this.btnGenerateCells.UseVisualStyleBackColor = true;
            this.btnGenerateCells.Click += new System.EventHandler(this.btnGenerateCells_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many columns in the universe?";
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(221, 59);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 20);
            this.txtColumns.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GameInitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 163);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.btnGenerateCells);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.txtRows);
            this.Name = "GameInitForm";
            this.Text = "GameInitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Button btnGenerateCells;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Button btnCancel;
    }
}