namespace Diplom
{
    partial class CalcFactor
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
            this.lGroupFactors = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelFactors = new System.Windows.Forms.Label();
            this.lbFactors = new System.Windows.Forms.ListBox();
            this.dGVFactors = new System.Windows.Forms.DataGridView();
            this.bReadyFactors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // lGroupFactors
            // 
            this.lGroupFactors.AutoSize = true;
            this.lGroupFactors.Location = new System.Drawing.Point(9, 28);
            this.lGroupFactors.Name = "lGroupFactors";
            this.lGroupFactors.Size = new System.Drawing.Size(97, 13);
            this.lGroupFactors.TabIndex = 0;
            this.lGroupFactors.Text = "Группа факторов:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 4;
            this.listBox1.Items.AddRange(new object[] {
            "1. Обуславливаемые характером обрабатываемой информации ",
            "2. Обуславливаемые архитектурой АСОД",
            "3. Обуславливаемые условиями функционирования  АСОД",
            "4. Обуславливаемые технологией обработки информации",
            "5. Обуславливаемые организацией работы АСОД"});
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 82);
            this.listBox1.TabIndex = 3;
            // 
            // labelFactors
            // 
            this.labelFactors.AutoSize = true;
            this.labelFactors.Location = new System.Drawing.Point(383, 28);
            this.labelFactors.Name = "labelFactors";
            this.labelFactors.Size = new System.Drawing.Size(58, 13);
            this.labelFactors.TabIndex = 2;
            this.labelFactors.Text = "Факторы:";
            // 
            // lbFactors
            // 
            this.lbFactors.FormattingEnabled = true;
            this.lbFactors.Items.AddRange(new object[] {
            "1. Фактор",
            "2. Фактор",
            "3. Фактор"});
            this.lbFactors.Location = new System.Drawing.Point(386, 62);
            this.lbFactors.Name = "lbFactors";
            this.lbFactors.Size = new System.Drawing.Size(237, 82);
            this.lbFactors.TabIndex = 3;
            // 
            // dGVFactors
            // 
            this.dGVFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFactors.Location = new System.Drawing.Point(12, 185);
            this.dGVFactors.Name = "dGVFactors";
            this.dGVFactors.Size = new System.Drawing.Size(290, 150);
            this.dGVFactors.TabIndex = 4;
            this.dGVFactors.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVFactors_CellEndEdit);
            // 
            // bReadyFactors
            // 
            this.bReadyFactors.Location = new System.Drawing.Point(12, 365);
            this.bReadyFactors.Name = "bReadyFactors";
            this.bReadyFactors.Size = new System.Drawing.Size(112, 23);
            this.bReadyFactors.TabIndex = 5;
            this.bReadyFactors.Text = "Готово";
            this.bReadyFactors.UseVisualStyleBackColor = true;
            this.bReadyFactors.Click += new System.EventHandler(this.bReadyFactors_Click);
            // 
            // CalcFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.bReadyFactors);
            this.Controls.Add(this.dGVFactors);
            this.Controls.Add(this.lbFactors);
            this.Controls.Add(this.labelFactors);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lGroupFactors);
            this.Name = "CalcFactor";
            this.Text = "CalcFactor";
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGroupFactors;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelFactors;
        private System.Windows.Forms.ListBox lbFactors;
        private System.Windows.Forms.DataGridView dGVFactors;
        private System.Windows.Forms.Button bReadyFactors;
    }
}