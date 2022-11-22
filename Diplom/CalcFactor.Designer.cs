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
            this.lbGroupFactors = new System.Windows.Forms.ListBox();
            this.labelFactors = new System.Windows.Forms.Label();
            this.lbFactors = new System.Windows.Forms.ListBox();
            this.dGVFactors = new System.Windows.Forms.DataGridView();
            this.bReadyFactors = new System.Windows.Forms.Button();
            this.dgvFactorsWeight = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorsWeight)).BeginInit();
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
            // lbGroupFactors
            // 
            this.lbGroupFactors.FormattingEnabled = true;
            this.lbGroupFactors.HorizontalExtent = 4;
            this.lbGroupFactors.Items.AddRange(new object[] {
            "1. Обуславливаемые характером обрабатываемой информации ",
            "2. Обуславливаемые архитектурой АСОД",
            "3. Обуславливаемые условиями функционирования  АСОД",
            "4. Обуславливаемые технологией обработки информации",
            "5. Обуславливаемые организацией работы АСОД"});
            this.lbGroupFactors.Location = new System.Drawing.Point(12, 62);
            this.lbGroupFactors.Name = "lbGroupFactors";
            this.lbGroupFactors.Size = new System.Drawing.Size(340, 82);
            this.lbGroupFactors.TabIndex = 3;
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
            "Фактор",
            "Фактор",
            "Фактор"});
            this.lbFactors.Location = new System.Drawing.Point(386, 62);
            this.lbFactors.Name = "lbFactors";
            this.lbFactors.Size = new System.Drawing.Size(248, 82);
            this.lbFactors.TabIndex = 3;
            // 
            // dGVFactors
            // 
            this.dGVFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFactors.Location = new System.Drawing.Point(12, 185);
            this.dGVFactors.Name = "dGVFactors";
            this.dGVFactors.RowHeadersWidth = 51;
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
            this.bReadyFactors.Text = "Далее";
            this.bReadyFactors.UseVisualStyleBackColor = true;
            this.bReadyFactors.Click += new System.EventHandler(this.bReadyFactors_Click);
            // 
            // dgvFactorsWeight
            // 
            this.dgvFactorsWeight.AllowUserToAddRows = false;
            this.dgvFactorsWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactorsWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactorsWeight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.dgvFactorsWeight.Location = new System.Drawing.Point(321, 185);
            this.dgvFactorsWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFactorsWeight.Name = "dgvFactorsWeight";
            this.dgvFactorsWeight.RowHeadersWidth = 51;
            this.dgvFactorsWeight.RowTemplate.Height = 24;
            this.dgvFactorsWeight.Size = new System.Drawing.Size(532, 150);
            this.dgvFactorsWeight.TabIndex = 6;
            // 
            // col1
            // 
            this.col1.HeaderText = "1-ая";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "2-ая";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "3-я";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "4-ая";
            this.col4.Name = "col4";
            // 
            // col5
            // 
            this.col5.HeaderText = "5-ая";
            this.col5.Name = "col5";
            // 
            // CalcFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.dgvFactorsWeight);
            this.Controls.Add(this.bReadyFactors);
            this.Controls.Add(this.dGVFactors);
            this.Controls.Add(this.lbFactors);
            this.Controls.Add(this.labelFactors);
            this.Controls.Add(this.lbGroupFactors);
            this.Controls.Add(this.lGroupFactors);
            this.Name = "CalcFactor";
            this.Text = "CalcFactor";
            ((System.ComponentModel.ISupportInitialize)(this.dGVFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorsWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGroupFactors;
        private System.Windows.Forms.ListBox lbGroupFactors;
        private System.Windows.Forms.Label labelFactors;
        private System.Windows.Forms.ListBox lbFactors;
        private System.Windows.Forms.DataGridView dGVFactors;
        private System.Windows.Forms.Button bReadyFactors;
        private System.Windows.Forms.DataGridView dgvFactorsWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
    }
}