namespace Diplom
{
    partial class CharactersOfClass
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ИАФ.1",
            "Идентификация и аутентификация пользователей, являющихся работниками оператора"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ИАФ.2",
            "Управление идентификаторами, в том числе создание, присвоение, уничтожение иденти" +
                "фикаторов"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "ИАФ.3",
            "Управление средствами аутентификации, в том числе хранение выдача, инициализация," +
                " блокирование средств аутентификации и принятие мер в случае утраты и (или) комп" +
                "рометации средств аутентификации"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ИАФ.4",
            "Защита обратной связи при вводе аутентификационной информации"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "ИАФ.5",
            "Идентификация и аутентификация пользователей, не являющихся работниками оператора" +
                " (внешних пользователей)"}, -1);
            this.lVRequirements = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lClassSystem = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lVRequirements
            // 
            this.lVRequirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lVRequirements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnTitle});
            this.lVRequirements.FullRowSelect = true;
            this.lVRequirements.GridLines = true;
            this.lVRequirements.HideSelection = false;
            listViewItem1.UseItemStyleForSubItems = false;
            this.lVRequirements.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lVRequirements.Location = new System.Drawing.Point(11, 73);
            this.lVRequirements.Margin = new System.Windows.Forms.Padding(2);
            this.lVRequirements.Name = "lVRequirements";
            this.lVRequirements.Scrollable = false;
            this.lVRequirements.Size = new System.Drawing.Size(545, 259);
            this.lVRequirements.TabIndex = 3;
            this.lVRequirements.UseCompatibleStateImageBehavior = false;
            this.lVRequirements.View = System.Windows.Forms.View.Details;
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "";
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Идентификация и аутентификация субъектов доступа и объектов доступа (ИАФ)";
            this.columnTitle.Width = 520;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(200, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 18);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Класс системы:";
            // 
            // lClassSystem
            // 
            this.lClassSystem.AutoSize = true;
            this.lClassSystem.BackColor = System.Drawing.SystemColors.Control;
            this.lClassSystem.Depth = 0;
            this.lClassSystem.Font = new System.Drawing.Font("Roboto", 11F);
            this.lClassSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lClassSystem.Location = new System.Drawing.Point(321, 11);
            this.lClassSystem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lClassSystem.Name = "lClassSystem";
            this.lClassSystem.Size = new System.Drawing.Size(0, 18);
            this.lClassSystem.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(226, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 18);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Требования";
            // 
            // CharactersOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 343);
            this.Controls.Add(this.lVRequirements);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lClassSystem);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CharactersOfClass";
            this.Text = "CharactersOfClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lVRequirements;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lClassSystem;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}