namespace Diplom
{
    partial class CalcCoeff
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
            this.lbGroupFactors = new System.Windows.Forms.ListBox();
            this.lFactor = new System.Windows.Forms.Label();
            this.lbFactor = new System.Windows.Forms.ListBox();
            this.lValueFactor = new System.Windows.Forms.Label();
            this.rbVeryHigh = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.bReady = new System.Windows.Forms.Button();
            this.dgvFactorsWatch = new System.Windows.Forms.DataGridView();
            this.dgvGroupFactorsWatch = new System.Windows.Forms.DataGridView();
            this.bCalculateCoeff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCoeffConcord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorsWatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupFactorsWatch)).BeginInit();
            this.SuspendLayout();
            // 
            // lGroupFactors
            // 
            this.lGroupFactors.AutoSize = true;
            this.lGroupFactors.Location = new System.Drawing.Point(32, 41);
            this.lGroupFactors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGroupFactors.Name = "lGroupFactors";
            this.lGroupFactors.Size = new System.Drawing.Size(127, 17);
            this.lGroupFactors.TabIndex = 0;
            this.lGroupFactors.Text = "Группа факторов:";
            // 
            // lbGroupFactors
            // 
            this.lbGroupFactors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGroupFactors.FormattingEnabled = true;
            this.lbGroupFactors.ItemHeight = 16;
            this.lbGroupFactors.Items.AddRange(new object[] {
            "Обуславливаемые характером обрабатываемой информации ",
            "Обуславливаемые архитектурой АСОД",
            "Обуславливаемые условиями функционирования  АСОД",
            "Обуславливаемые технологией обработки информации",
            "Обуславливаемые организацией работы АСОД"});
            this.lbGroupFactors.Location = new System.Drawing.Point(36, 79);
            this.lbGroupFactors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbGroupFactors.Name = "lbGroupFactors";
            this.lbGroupFactors.Size = new System.Drawing.Size(447, 114);
            this.lbGroupFactors.TabIndex = 1;
            this.lbGroupFactors.SelectedIndexChanged += new System.EventHandler(this.lbGroupFactors_SelectedIndexChanged);
            // 
            // lFactor
            // 
            this.lFactor.AutoSize = true;
            this.lFactor.Location = new System.Drawing.Point(505, 41);
            this.lFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFactor.Name = "lFactor";
            this.lFactor.Size = new System.Drawing.Size(63, 17);
            this.lFactor.TabIndex = 2;
            this.lFactor.Text = "Фактор:";
            // 
            // lbFactor
            // 
            this.lbFactor.FormattingEnabled = true;
            this.lbFactor.ItemHeight = 16;
            this.lbFactor.Items.AddRange(new object[] {
            "Фактор №1",
            "Фактор №2",
            "Фактор №3"});
            this.lbFactor.Location = new System.Drawing.Point(509, 79);
            this.lbFactor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFactor.Name = "lbFactor";
            this.lbFactor.Size = new System.Drawing.Size(447, 116);
            this.lbFactor.TabIndex = 3;
            // 
            // lValueFactor
            // 
            this.lValueFactor.AutoSize = true;
            this.lValueFactor.Location = new System.Drawing.Point(32, 249);
            this.lValueFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lValueFactor.Name = "lValueFactor";
            this.lValueFactor.Size = new System.Drawing.Size(138, 17);
            this.lValueFactor.TabIndex = 4;
            this.lValueFactor.Text = "Значение фактора:";
            // 
            // rbVeryHigh
            // 
            this.rbVeryHigh.AutoSize = true;
            this.rbVeryHigh.Location = new System.Drawing.Point(36, 287);
            this.rbVeryHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbVeryHigh.Name = "rbVeryHigh";
            this.rbVeryHigh.Size = new System.Drawing.Size(110, 21);
            this.rbVeryHigh.TabIndex = 5;
            this.rbVeryHigh.Text = "radioButton1";
            this.rbVeryHigh.UseVisualStyleBackColor = true;
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(36, 326);
            this.rbHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(110, 21);
            this.rbHigh.TabIndex = 6;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "radioButton2";
            this.rbHigh.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(36, 368);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(110, 21);
            this.rbMedium.TabIndex = 7;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "radioButton3";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(36, 407);
            this.rbLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(110, 21);
            this.rbLow.TabIndex = 8;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "radioButton4";
            this.rbLow.UseVisualStyleBackColor = true;
            // 
            // bReady
            // 
            this.bReady.Location = new System.Drawing.Point(36, 468);
            this.bReady.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bReady.Name = "bReady";
            this.bReady.Size = new System.Drawing.Size(100, 28);
            this.bReady.TabIndex = 9;
            this.bReady.Text = "Готово";
            this.bReady.UseVisualStyleBackColor = true;
            this.bReady.Click += new System.EventHandler(this.bReady_Click);
            // 
            // dgvFactorsWatch
            // 
            this.dgvFactorsWatch.AllowUserToAddRows = false;
            this.dgvFactorsWatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactorsWatch.Location = new System.Drawing.Point(853, 249);
            this.dgvFactorsWatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFactorsWatch.Name = "dgvFactorsWatch";
            this.dgvFactorsWatch.RowHeadersWidth = 51;
            this.dgvFactorsWatch.Size = new System.Drawing.Size(71, 185);
            this.dgvFactorsWatch.TabIndex = 10;
            this.dgvFactorsWatch.Visible = false;
            // 
            // dgvGroupFactorsWatch
            // 
            this.dgvGroupFactorsWatch.AllowUserToAddRows = false;
            this.dgvGroupFactorsWatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupFactorsWatch.Location = new System.Drawing.Point(980, 249);
            this.dgvGroupFactorsWatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGroupFactorsWatch.Name = "dgvGroupFactorsWatch";
            this.dgvGroupFactorsWatch.RowHeadersWidth = 51;
            this.dgvGroupFactorsWatch.Size = new System.Drawing.Size(71, 185);
            this.dgvGroupFactorsWatch.TabIndex = 11;
            this.dgvGroupFactorsWatch.Visible = false;
            // 
            // bCalculateCoeff
            // 
            this.bCalculateCoeff.Location = new System.Drawing.Point(36, 468);
            this.bCalculateCoeff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCalculateCoeff.Name = "bCalculateCoeff";
            this.bCalculateCoeff.Size = new System.Drawing.Size(100, 28);
            this.bCalculateCoeff.TabIndex = 12;
            this.bCalculateCoeff.Text = "Рассчитать ";
            this.bCalculateCoeff.UseVisualStyleBackColor = true;
            this.bCalculateCoeff.Visible = false;
            this.bCalculateCoeff.Click += new System.EventHandler(this.bCalculateCoeff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Коэффициент конкордации:";
            // 
            // tbCoeffConcord
            // 
            this.tbCoeffConcord.Location = new System.Drawing.Point(349, 287);
            this.tbCoeffConcord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCoeffConcord.Name = "tbCoeffConcord";
            this.tbCoeffConcord.Size = new System.Drawing.Size(193, 22);
            this.tbCoeffConcord.TabIndex = 14;
            // 
            // CalcCoeff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbCoeffConcord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCalculateCoeff);
            this.Controls.Add(this.dgvGroupFactorsWatch);
            this.Controls.Add(this.dgvFactorsWatch);
            this.Controls.Add(this.bReady);
            this.Controls.Add(this.rbLow);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbHigh);
            this.Controls.Add(this.rbVeryHigh);
            this.Controls.Add(this.lValueFactor);
            this.Controls.Add(this.lbFactor);
            this.Controls.Add(this.lFactor);
            this.Controls.Add(this.lbGroupFactors);
            this.Controls.Add(this.lGroupFactors);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalcCoeff";
            this.Text = "CalcCoeff";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorsWatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupFactorsWatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGroupFactors;
        private System.Windows.Forms.ListBox lbGroupFactors;
        private System.Windows.Forms.Label lFactor;
        private System.Windows.Forms.ListBox lbFactor;
        private System.Windows.Forms.Label lValueFactor;
        private System.Windows.Forms.RadioButton rbVeryHigh;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.Button bReady;
        private System.Windows.Forms.DataGridView dgvFactorsWatch;
        private System.Windows.Forms.DataGridView dgvGroupFactorsWatch;
        private System.Windows.Forms.Button bCalculateCoeff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCoeffConcord;
    }
}