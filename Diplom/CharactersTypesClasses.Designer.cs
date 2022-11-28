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
            this.label1 = new System.Windows.Forms.Label();
            this.ClassTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvClassesTypes.Location = new System.Drawing.Point(16, 43);
            this.dgvClassesTypes.Name = "dgvClassesTypes";
            this.dgvClassesTypes.RowHeadersWidth = 51;
            this.dgvClassesTypes.RowTemplate.Height = 24;
            this.dgvClassesTypes.Size = new System.Drawing.Size(429, 184);
            this.dgvClassesTypes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Характеристики типовых СЗИ";
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
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(179, 233);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(117, 31);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // CharactersTypesClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 273);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClassesTypes);
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