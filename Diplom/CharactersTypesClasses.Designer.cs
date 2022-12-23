namespace Diplom
{
    partial class CharactersTypesClasses
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
            this.dgvClassesTypes = new System.Windows.Forms.DataGridView();
            this.ClassTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassesTypes
            // 
            this.dgvClassesTypes.AllowUserToAddRows = false;
            this.dgvClassesTypes.AllowUserToDeleteRows = false;
            this.dgvClassesTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassesTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassTitle,
            this.Coefficient,
            this.Class});
            this.dgvClassesTypes.Location = new System.Drawing.Point(12, 35);
            this.dgvClassesTypes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClassesTypes.Name = "dgvClassesTypes";
            this.dgvClassesTypes.RowHeadersWidth = 51;
            this.dgvClassesTypes.RowTemplate.Height = 24;
            this.dgvClassesTypes.Size = new System.Drawing.Size(322, 150);
            this.dgvClassesTypes.TabIndex = 0;
            // 
            // ClassTitle
            // 
            this.ClassTitle.HeaderText = "Имя класса";
            this.ClassTitle.MinimumWidth = 6;
            this.ClassTitle.Name = "ClassTitle";
            this.ClassTitle.ReadOnly = true;
            this.ClassTitle.Width = 125;
            // 
            // Coefficient
            // 
            this.Coefficient.HeaderText = "Коэффициент";
            this.Coefficient.MinimumWidth = 6;
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.ReadOnly = true;
            this.Coefficient.Width = 125;
            // 
            // Class
            // 
            this.Class.HeaderText = "Класс";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Характеристики типовых СЗИ";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(119, 193);
            this.bClose.Margin = new System.Windows.Forms.Padding(2);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(88, 25);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // CharactersTypesClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 229);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClassesTypes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CharactersTypesClasses";
            this.Text = "CharactersTypesClasses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassesTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.Button bClose;
    }
}