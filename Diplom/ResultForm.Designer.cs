namespace Diplom
{
    partial class ResultForm
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
            this.lCoeff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lCoeff
            // 
            this.lCoeff.AutoSize = true;
            this.lCoeff.Location = new System.Drawing.Point(12, 9);
            this.lCoeff.MaximumSize = new System.Drawing.Size(180, 25);
            this.lCoeff.Name = "lCoeff";
            this.lCoeff.Size = new System.Drawing.Size(169, 13);
            this.lCoeff.TabIndex = 0;
            this.lCoeff.Text = "Коэффициент защищенности = ";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 178);
            this.Controls.Add(this.lCoeff);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCoeff;
    }
}