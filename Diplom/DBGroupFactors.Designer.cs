namespace Diplom
{
    partial class DBGroupFactors
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
            this.dgvDBGroupsFactor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBGroupsFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDBGroupsFactor
            // 
            this.dgvDBGroupsFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBGroupsFactor.Location = new System.Drawing.Point(13, 37);
            this.dgvDBGroupsFactor.Name = "dgvDBGroupsFactor";
            this.dgvDBGroupsFactor.Size = new System.Drawing.Size(592, 302);
            this.dgvDBGroupsFactor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группы факторов:";
            // 
            // DBGroupFactors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDBGroupsFactor);
            this.Name = "DBGroupFactors";
            this.Text = "DBGroupFactors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBGroupsFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDBGroupsFactor;
        private System.Windows.Forms.Label label1;
    }
}