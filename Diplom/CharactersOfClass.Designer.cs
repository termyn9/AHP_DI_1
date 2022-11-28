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
            this.label1 = new System.Windows.Forms.Label();
            this.lClassSystem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lVRequirements = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Класс системы: ";
            // 
            // lClassSystem
            // 
            this.lClassSystem.AutoSize = true;
            this.lClassSystem.Location = new System.Drawing.Point(333, 23);
            this.lClassSystem.Name = "lClassSystem";
            this.lClassSystem.Size = new System.Drawing.Size(0, 17);
            this.lClassSystem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Требования";
            // 
            // lVRequirements
            // 
            this.lVRequirements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnTitle});
            this.lVRequirements.HideSelection = false;
            this.lVRequirements.Location = new System.Drawing.Point(12, 85);
            this.lVRequirements.Name = "lVRequirements";
            this.lVRequirements.Size = new System.Drawing.Size(548, 170);
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
            // 
            // CharactersOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 267);
            this.Controls.Add(this.lVRequirements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lClassSystem);
            this.Controls.Add(this.label1);
            this.Name = "CharactersOfClass";
            this.Text = "CharactersOfClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lClassSystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lVRequirements;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnTitle;
    }
}