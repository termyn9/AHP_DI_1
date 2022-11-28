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
        double sumX = 0;
        double sumKAVG = 0;

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

            double[,] arrayK = new double[dgvExpertMarks.Rows.Count, dgvExpertMarks.ColumnCount];
            double[] arrayKAVG = new double[dgvExpertMarks.Rows.Count];
            double[] arrayKprom = new double[dgvExpertMarks.RowCount];
            double[] arrayKResult = new double[dgvExpertMarks.ColumnCount];
            double[] arrayVprom = new double[dgvExpertMarks.ColumnCount];
            double[] arrayV = new double[dgvExpertMarks.RowCount];

            for (int i = 1; i <= dgvDBGroups.Rows.Count / 5; i++)
            {
                dgvExpertMarks.Columns[i].HeaderCell.Value = ($"{i}-ый эксперт").ToString();
                for (int j = 0; j < 5; j++)
                {
                   dgvExpertMarks.Rows[j].Cells[i].Value = dgvDBGroups.Rows[RowCount].Cells[3].Value;
                   RowCount++;
                }
            }

            for (int i = 0; i < dgvExpertMarks.Rows.Count; i++)
            {
                for (int j = 0; j < dgvExpertMarks.Columns.Count; j++)
                {
                    sumX += Convert.ToDouble(dgvExpertMarks.Rows[i].Cells[j].Value) / dgvExpertMarks.Columns.Count;
                }

                for (int k = 0; k < dgvExpertMarks.Columns.Count; k++)
                {
                    arrayK[i, k] = 1 - Math.Abs(sumX - Convert.ToDouble(dgvExpertMarks.Rows[i].Cells[k].Value)) / 9;
                }

                sumX = 0;


            }

            for (int i = 0; i < dgvExpertMarks.Rows.Count; i++)
            {
                for (int j = 0; j < arrayKAVG.Length; j++)
                {
                    arrayKprom[i] += arrayK[j, i];
                }
                arrayKAVG[i] = arrayKprom[i] / dgvExpertMarks.RowCount;

                sumKAVG += arrayKAVG[i];
            }

            //for (int i = 0; i < arrayKResult.Length; i++)
            //{
            //    arrayKResult[i] = arrayKAVG[i] / sumKAVG;
            //}

            //for (int i = 0; i < dgvExpertMarks.Columns.Count; i++)
            //{
            //    for (int j = 0; j < dgvExpertMarks.Rows.Count; j++)
            //    {
            //        arrayVprom[i] += arrayK[i, j] * arrayKResult[i];
            //    }
            //}
        }
    }
}
