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
            this.lGroupFactors.Location = new System.Drawing.Point(24, 33);
            this.lGroupFactors.Name = "lGroupFactors";
            this.lGroupFactors.Size = new System.Drawing.Size(97, 13);
            this.lGroupFactors.TabIndex = 0;
            this.lGroupFactors.Text = "Группа факторов:";
            // 
            // lbGroupFactors
            // 
            this.lbGroupFactors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGroupFactors.FormattingEnabled = true;
            this.lbGroupFactors.Items.AddRange(new object[] {
            "Обуславливаемые характером обрабатываемой информации ",
            "Обуславливаемые архитектурой АСОД",
            "Обуславливаемые условиями функционирования  АСОД",
            "Обуславливаемые технологией обработки информации",
            "Обуславливаемые организацией работы АСОД"});
            this.lbGroupFactors.Location = new System.Drawing.Point(27, 64);
            this.lbGroupFactors.Name = "lbGroupFactors";
            this.lbGroupFactors.Size = new System.Drawing.Size(336, 93);
            this.lbGroupFactors.TabIndex = 1;
            this.lbGroupFactors.SelectedIndexChanged += new System.EventHandler(this.lbGroupFactors_SelectedIndexChanged);
            // 
            // lFactor
            // 
            this.lFactor.AutoSize = true;
            this.lFactor.Location = new System.Drawing.Point(379, 33);
            this.lFactor.Name = "lFactor";
            this.lFactor.Size = new System.Drawing.Size(50, 13);
            this.lFactor.TabIndex = 2;
            this.lFactor.Text = "Фактор:";
            // 
            // lbFactor
            // 
            this.lbFactor.FormattingEnabled = true;
            this.lbFactor.Items.AddRange(new object[] {
            "Фактор №1",
            "Фактор №2",
            "Фактор №3"});
            this.lbFactor.Location = new System.Drawing.Point(382, 64);
            this.lbFactor.Name = "lbFactor";
            this.lbFactor.Size = new System.Drawing.Size(336, 95);
            this.lbFactor.TabIndex = 3;
            // 
            // lValueFactor
            // 
            this.lValueFactor.AutoSize = true;
            this.lValueFactor.Location = new System.Drawing.Point(24, 202);
            this.lValueFactor.Name = "lValueFactor";
            this.lValueFactor.Size = new System.Drawing.Size(104, 13);
            this.lValueFactor.TabIndex = 4;
            this.lValueFactor.Text = "Значение фактора:";
            // 
            // rbVeryHigh
            // 
            this.rbVeryHigh.AutoSize = true;
            this.rbVeryHigh.Location = new System.Drawing.Point(27, 233);
            this.rbVeryHigh.Name = "rbVeryHigh";
            this.rbVeryHigh.Size = new System.Drawing.Size(85, 17);
            this.rbVeryHigh.TabIndex = 5;
            this.rbVeryHigh.Text = "radioButton1";
            this.rbVeryHigh.UseVisualStyleBackColor = true;
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(27, 265);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(85, 17);
            this.rbHigh.TabIndex = 6;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "radioButton2";
            this.rbHigh.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(27, 299);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(85, 17);
            this.rbMedium.TabIndex = 7;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "radioButton3";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(27, 331);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(85, 17);
            this.rbLow.TabIndex = 8;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "radioButton4";
            this.rbLow.UseVisualStyleBackColor = true;
            // 
            // bReady
            // 
            this.bReady.Location = new System.Drawing.Point(27, 380);
            this.bReady.Name = "bReady";
            this.bReady.Size = new System.Drawing.Size(75, 23);
            this.bReady.TabIndex = 9;
            this.bReady.Text = "Готово";
            this.bReady.UseVisualStyleBackColor = true;
            this.bReady.Click += new System.EventHandler(this.bReady_Click);
            // 
            // dgvFactorsWatch
            // 
            this.dgvFactorsWatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactorsWatch.Location = new System.Drawing.Point(640, 202);
            this.dgvFactorsWatch.Name = "dgvFactorsWatch";
            this.dgvFactorsWatch.Size = new System.Drawing.Size(53, 150);
            this.dgvFactorsWatch.TabIndex = 10;
            this.dgvFactorsWatch.Visible = false;
            // 
            // dgvGroupFactorsWatch
            // 
            this.dgvGroupFactorsWatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupFactorsWatch.Location = new System.Drawing.Point(735, 202);
            this.dgvGroupFactorsWatch.Name = "dgvGroupFactorsWatch";
            this.dgvGroupFactorsWatch.Size = new System.Drawing.Size(53, 150);
            this.dgvGroupFactorsWatch.TabIndex = 11;
            this.dgvGroupFactorsWatch.Visible = false;
            // 
            // bCalculateCoeff
            // 
            this.bCalculateCoeff.Location = new System.Drawing.Point(27, 380);
            this.bCalculateCoeff.Name = "bCalculateCoeff";
            this.bCalculateCoeff.Size = new System.Drawing.Size(75, 23);
            this.bCalculateCoeff.TabIndex = 12;
            this.bCalculateCoeff.Text = "Рассчитать ";
            this.bCalculateCoeff.UseVisualStyleBackColor = true;
            this.bCalculateCoeff.Visible = false;
            this.bCalculateCoeff.Click += new System.EventHandler(this.bCalculateCoeff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Коэффициент конкордации:";
            // 
            // tbCoeffConcord
            // 
            this.tbCoeffConcord.Location = new System.Drawing.Point(262, 233);
            this.tbCoeffConcord.Name = "tbCoeffConcord";
            this.tbCoeffConcord.Size = new System.Drawing.Size(146, 20);
            this.tbCoeffConcord.TabIndex = 14;
            // 
            // CalcCoeff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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