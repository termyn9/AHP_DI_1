namespace Diplom
{
    partial class CalcGroupFactor
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
            this.labelGroup = new System.Windows.Forms.Label();
            this.lbGroupFactor = new System.Windows.Forms.ListBox();
            this.dGVGroupFactor = new System.Windows.Forms.DataGridView();
            this.bReadyGroupFactor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGroupFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(24, 21);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(121, 13);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Оцениваемые группы:";
            // 
            // lbGroupFactor
            // 
            this.lbGroupFactor.FormattingEnabled = true;
            this.lbGroupFactor.Items.AddRange(new object[] {
            "Обуславливаемые характером обрабатываемой информации ",
            "Обуславливаемые архитектурой АСОД",
            "Обуславливаемые условиями функционирования  АСОД",
            "Обуславливаемые технологией обработки информации",
            "Обуславливаемые организацией работы АСОД"});
            this.lbGroupFactor.Location = new System.Drawing.Point(27, 52);
            this.lbGroupFactor.MultiColumn = true;
            this.lbGroupFactor.Name = "lbGroupFactor";
            this.lbGroupFactor.Size = new System.Drawing.Size(325, 95);
            this.lbGroupFactor.TabIndex = 1;
            // 
            // dGVGroupFactor
            // 
            this.dGVGroupFactor.AllowUserToOrderColumns = true;
            this.dGVGroupFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGroupFactor.Location = new System.Drawing.Point(388, 52);
            this.dGVGroupFactor.Name = "dGVGroupFactor";
            this.dGVGroupFactor.Size = new System.Drawing.Size(349, 190);
            this.dGVGroupFactor.TabIndex = 2;
            // 
            // bReadyGroupFactor
            // 
            this.bReadyGroupFactor.Location = new System.Drawing.Point(560, 272);
            this.bReadyGroupFactor.Name = "bReadyGroupFactor";
            this.bReadyGroupFactor.Size = new System.Drawing.Size(107, 45);
            this.bReadyGroupFactor.TabIndex = 3;
            this.bReadyGroupFactor.Text = "Готово";
            this.bReadyGroupFactor.UseVisualStyleBackColor = true;
            this.bReadyGroupFactor.Click += new System.EventHandler(this.bReadyGroupFactor_Click);
            // 
            // CalcGroupFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bReadyGroupFactor);
            this.Controls.Add(this.dGVGroupFactor);
            this.Controls.Add(this.lbGroupFactor);
            this.Controls.Add(this.labelGroup);
            this.Name = "CalcGroupFactor";
            this.Text = "CalcGroupFactor";
            this.Load += new System.EventHandler(this.CalcGroupFactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGroupFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ListBox lbGroupFactor;
        private System.Windows.Forms.DataGridView dGVGroupFactor;
        private System.Windows.Forms.Button bReadyGroupFactor;
    }
}