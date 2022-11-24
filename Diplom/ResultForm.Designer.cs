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
            this.lW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lLevelDef = new System.Windows.Forms.Label();
            this.lClassDef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lCoeff
            // 
            this.lCoeff.AutoSize = true;
            this.lCoeff.Location = new System.Drawing.Point(6, 70);
            this.lCoeff.MaximumSize = new System.Drawing.Size(180, 25);
            this.lCoeff.Name = "lCoeff";
            this.lCoeff.Size = new System.Drawing.Size(161, 13);
            this.lCoeff.TabIndex = 0;
            this.lCoeff.Text = "Значение коэффициента Wm: ";
            // 
            // lW
            // 
            this.lW.AutoSize = true;
            this.lW.Location = new System.Drawing.Point(181, 70);
            this.lW.Name = "lW";
            this.lW.Size = new System.Drawing.Size(0, 13);
            this.lW.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.MaximumSize = new System.Drawing.Size(180, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Уровень защиты: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.MaximumSize = new System.Drawing.Size(180, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Класс защищенности: ";
            // 
            // lLevelDef
            // 
            this.lLevelDef.AutoSize = true;
            this.lLevelDef.Location = new System.Drawing.Point(112, 47);
            this.lLevelDef.MaximumSize = new System.Drawing.Size(180, 25);
            this.lLevelDef.Name = "lLevelDef";
            this.lLevelDef.Size = new System.Drawing.Size(0, 13);
            this.lLevelDef.TabIndex = 4;
            // 
            // lClassDef
            // 
            this.lClassDef.AutoSize = true;
            this.lClassDef.Location = new System.Drawing.Point(136, 95);
            this.lClassDef.MaximumSize = new System.Drawing.Size(180, 25);
            this.lClassDef.Name = "lClassDef";
            this.lClassDef.Size = new System.Drawing.Size(0, 13);
            this.lClassDef.TabIndex = 5;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 178);
            this.Controls.Add(this.lClassDef);
            this.Controls.Add(this.lLevelDef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lW);
            this.Controls.Add(this.lCoeff);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCoeff;
        private System.Windows.Forms.Label lW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lLevelDef;
        private System.Windows.Forms.Label lClassDef;
    }
}