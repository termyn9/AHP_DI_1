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
            this.lVGroupFactors = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lIS = new System.Windows.Forms.Label();
            this.tbIS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOS = new System.Windows.Forms.TextBox();
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
            this.lbGroupFactor.ColumnWidth = 4;
            this.lbGroupFactor.FormattingEnabled = true;
            this.lbGroupFactor.HorizontalExtent = 4;
            this.lbGroupFactor.Items.AddRange(new object[] {
            "Обуславливаемые характером обрабатываемой информации ",
            "Обуславливаемые архитектурой АСОД",
            "Обуславливаемые условиями функционирования  АСОД",
            "Обуславливаемые технологией обработки информации",
            "Обуславливаемые организацией работы АСОД"});
            this.lbGroupFactor.Location = new System.Drawing.Point(12, 428);
            this.lbGroupFactor.MultiColumn = true;
            this.lbGroupFactor.Name = "lbGroupFactor";
            this.lbGroupFactor.Size = new System.Drawing.Size(10, 4);
            this.lbGroupFactor.TabIndex = 1;
            this.lbGroupFactor.Visible = false;
            // 
            // dGVGroupFactor
            // 
            this.dGVGroupFactor.AllowUserToOrderColumns = true;
            this.dGVGroupFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGroupFactor.Location = new System.Drawing.Point(388, 12);
            this.dGVGroupFactor.Name = "dGVGroupFactor";
            this.dGVGroupFactor.Size = new System.Drawing.Size(400, 190);
            this.dGVGroupFactor.TabIndex = 2;
            this.dGVGroupFactor.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGroupFactor_CellEndEdit);
            // 
            // bReadyGroupFactor
            // 
            this.bReadyGroupFactor.Location = new System.Drawing.Point(567, 233);
            this.bReadyGroupFactor.Name = "bReadyGroupFactor";
            this.bReadyGroupFactor.Size = new System.Drawing.Size(107, 45);
            this.bReadyGroupFactor.TabIndex = 3;
            this.bReadyGroupFactor.Text = "Готово";
            this.bReadyGroupFactor.UseVisualStyleBackColor = true;
            this.bReadyGroupFactor.Click += new System.EventHandler(this.bReadyGroupFactor_Click);
            // 
            // lVGroupFactors
            // 
            this.lVGroupFactors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnTitle});
            this.lVGroupFactors.HideSelection = false;
            this.lVGroupFactors.Location = new System.Drawing.Point(12, 49);
            this.lVGroupFactors.Name = "lVGroupFactors";
            this.lVGroupFactors.Size = new System.Drawing.Size(361, 153);
            this.lVGroupFactors.TabIndex = 4;
            this.lVGroupFactors.UseCompatibleStateImageBehavior = false;
            this.lVGroupFactors.View = System.Windows.Forms.View.Details;
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "";
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Группа факторов";
            this.columnTitle.Width = 225;
            // 
            // lIS
            // 
            this.lIS.AutoSize = true;
            this.lIS.Location = new System.Drawing.Point(12, 233);
            this.lIS.Name = "lIS";
            this.lIS.Size = new System.Drawing.Size(139, 13);
            this.lIS.TabIndex = 5;
            this.lIS.Text = "Индекс согласованности:";
            // 
            // tbIS
            // 
            this.tbIS.Location = new System.Drawing.Point(15, 258);
            this.tbIS.Name = "tbIS";
            this.tbIS.Size = new System.Drawing.Size(130, 20);
            this.tbIS.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Отношение согласованности:";
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(12, 328);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(155, 20);
            this.tbOS.TabIndex = 8;
            // 
            // CalcGroupFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIS);
            this.Controls.Add(this.lIS);
            this.Controls.Add(this.lVGroupFactors);
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
        private System.Windows.Forms.ListView lVGroupFactors;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.Label lIS;
        private System.Windows.Forms.TextBox tbIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOS;
    }
}