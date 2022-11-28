using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class CoeffTolerant : Form
    {
        CoeffContext db;
        int RowCount = 0;
        public CoeffTolerant()
        {
            InitializeComponent();

            db = new CoeffContext();
            db.Groups.Load();

            dgvDBGroups.DataSource = db.Groups.Local.ToBindingList();
            dgvDBGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDBGroups.AllowUserToAddRows = false;

            dgvExpertMarks.Columns.Add("numberGroup", "Номер группы");
            dgvExpertMarks.RowCount = 5;
            
            for (int i = 0; i < 5; i++)
            {
                dgvExpertMarks.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            dgvExpertMarks.ColumnCount = dgvDBGroups.Rows.Count / 5 + 1;
            dgvExpertMarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDBGroups.AllowUserToAddRows = false;

            for (int i = 1; i <= dgvDBGroups.Rows.Count / 5; i++)
            {
                dgvExpertMarks.Columns[i].HeaderCell.Value = ($"{i}-ый эксперт").ToString();
                for (int j = 0; j < 5; j++)
                {
                   dgvExpertMarks.Rows[j].Cells[i].Value = dgvDBGroups.Rows[RowCount].Cells[3].Value;
                   RowCount++;
                }
            }
        }
    }
}
