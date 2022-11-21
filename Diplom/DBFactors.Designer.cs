namespace Diplom
{
    partial class DBFactors
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
            this.dgvFactors = new System.Windows.Forms.DataGridView();
            this.lFactors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactors
            // 
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Location = new System.Drawing.Point(13, 47);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.Size = new System.Drawing.Size(408, 150);
            this.dgvFactors.TabIndex = 0;
            // 
            // lFactors
            // 
            this.lFactors.AutoSize = true;
            this.lFactors.Location = new System.Drawing.Point(13, 13);
            this.lFactors.Name = "lFactors";
            this.lFactors.Size = new System.Drawing.Size(58, 13);
            this.lFactors.TabIndex = 1;
            this.lFactors.Text = "Факторы:";
            // 
            // DBFactors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 222);
            this.Controls.Add(this.lFactors);
            this.Controls.Add(this.dgvFactors);
            this.Name = "DBFactors";
            this.Text = "DBFactors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactors;
        private System.Windows.Forms.Label lFactors;
    }
}