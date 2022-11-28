namespace Diplom
{
    partial class CoeffTolerant
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
            this.dgvExpertMarks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDBGroups = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpertMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpertMarks
            // 
            this.dgvExpertMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpertMarks.Location = new System.Drawing.Point(12, 35);
            this.dgvExpertMarks.Name = "dgvExpertMarks";
            this.dgvExpertMarks.Size = new System.Drawing.Size(706, 207);
            this.dgvExpertMarks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Матрица экспертных оценок:";
            // 
            // dgvDBGroups
            // 
            this.dgvDBGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBGroups.Location = new System.Drawing.Point(567, 309);
            this.dgvDBGroups.Name = "dgvDBGroups";
            this.dgvDBGroups.Size = new System.Drawing.Size(151, 34);
            this.dgvDBGroups.TabIndex = 2;
            this.dgvDBGroups.Visible = false;
            // 
            // CoeffTolerant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 355);
            this.Controls.Add(this.dgvDBGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExpertMarks);
            this.Name = "CoeffTolerant";
            this.Text = "CoeffTolerant";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpertMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpertMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDBGroups;
    }
}