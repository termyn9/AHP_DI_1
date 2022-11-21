namespace Diplom
{
    partial class Form1
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
            this.cbGroupOrFactor = new System.Windows.Forms.ComboBox();
            this.labelExpAnalys = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.cbUserFunction = new System.Windows.Forms.ComboBox();
            this.lDB = new System.Windows.Forms.Label();
            this.cbDB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbGroupOrFactor
            // 
            this.cbGroupOrFactor.FormattingEnabled = true;
            this.cbGroupOrFactor.Items.AddRange(new object[] {
            "Группы факторов",
            "Факторы"});
            this.cbGroupOrFactor.Location = new System.Drawing.Point(33, 48);
            this.cbGroupOrFactor.Name = "cbGroupOrFactor";
            this.cbGroupOrFactor.Size = new System.Drawing.Size(121, 21);
            this.cbGroupOrFactor.TabIndex = 0;
            this.cbGroupOrFactor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelExpAnalys
            // 
            this.labelExpAnalys.AutoSize = true;
            this.labelExpAnalys.Location = new System.Drawing.Point(30, 22);
            this.labelExpAnalys.Name = "labelExpAnalys";
            this.labelExpAnalys.Size = new System.Drawing.Size(111, 13);
            this.labelExpAnalys.TabIndex = 1;
            this.labelExpAnalys.Text = "Экспертный анализ:";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(30, 122);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(83, 13);
            this.lUser.TabIndex = 2;
            this.lUser.Text = "Пользователь:";
            // 
            // cbUserFunction
            // 
            this.cbUserFunction.FormattingEnabled = true;
            this.cbUserFunction.Items.AddRange(new object[] {
            "Расчет коэффициента"});
            this.cbUserFunction.Location = new System.Drawing.Point(33, 157);
            this.cbUserFunction.Name = "cbUserFunction";
            this.cbUserFunction.Size = new System.Drawing.Size(121, 21);
            this.cbUserFunction.TabIndex = 3;
            this.cbUserFunction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lDB
            // 
            this.lDB.AutoSize = true;
            this.lDB.Location = new System.Drawing.Point(245, 22);
            this.lDB.Name = "lDB";
            this.lDB.Size = new System.Drawing.Size(75, 13);
            this.lDB.TabIndex = 4;
            this.lDB.Text = "База данных:";
            // 
            // cbDB
            // 
            this.cbDB.FormattingEnabled = true;
            this.cbDB.Items.AddRange(new object[] {
            "Группы факторов",
            "Факторы"});
            this.cbDB.Location = new System.Drawing.Point(238, 48);
            this.cbDB.Name = "cbDB";
            this.cbDB.Size = new System.Drawing.Size(121, 21);
            this.cbDB.TabIndex = 5;
            this.cbDB.SelectedIndexChanged += new System.EventHandler(this.cbDB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbDB);
            this.Controls.Add(this.lDB);
            this.Controls.Add(this.cbUserFunction);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.labelExpAnalys);
            this.Controls.Add(this.cbGroupOrFactor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroupOrFactor;
        private System.Windows.Forms.Label labelExpAnalys;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.ComboBox cbUserFunction;
        private System.Windows.Forms.Label lDB;
        private System.Windows.Forms.ComboBox cbDB;
    }
}

