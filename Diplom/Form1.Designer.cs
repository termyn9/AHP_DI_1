namespace Diplom
{
    partial class Form1
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
            this.cbGroupOrFactor = new System.Windows.Forms.ComboBox();
            this.labelExpAnalys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGroupOrFactor
            // 
            this.cbGroupOrFactor.FormattingEnabled = true;
            this.cbGroupOrFactor.Items.AddRange(new object[] {
            "Группы факторов",
            "Факторы"});
            this.cbGroupOrFactor.Location = new System.Drawing.Point(33, 48);
            this.cbGroupOrFactor.Name = "cbGroupOrFactor";
            this.cbGroupOrFactor.Size = new System.Drawing.Size(121, 21);
            this.cbGroupOrFactor.TabIndex = 0;
            this.cbGroupOrFactor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelExpAnalys
            // 
            this.labelExpAnalys.AutoSize = true;
            this.labelExpAnalys.Location = new System.Drawing.Point(30, 22);
            this.labelExpAnalys.Name = "labelExpAnalys";
            this.labelExpAnalys.Size = new System.Drawing.Size(111, 13);
            this.labelExpAnalys.TabIndex = 1;
            this.labelExpAnalys.Text = "Экспертный анализ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExpAnalys);
            this.Controls.Add(this.cbGroupOrFactor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroupOrFactor;
        private System.Windows.Forms.Label labelExpAnalys;
    }
}

