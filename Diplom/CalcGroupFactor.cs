using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class CalcGroupFactor : Form
    {
        double[,] PrioritiesGroupFactor;
        List<string> ListGroupFactor;
        List<string> valuesAutoFill = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "1/9", "1/8", "1/7", "1/6", "1/5", "1/4", "1/3", "1/2" };
        List<string> valuesGroup = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "1/2", "1/3", "1/4", "1/5", "1/6", "1/7", "1/8", "1/9" };


        public CalcGroupFactor()
        {
            InitializeComponent();

            this.ListGroupFactor = lbGroupFactor.Items.Cast<String>().ToList();
            this.PrioritiesGroupFactor = new double[ListGroupFactor.Count, ListGroupFactor.Count];

            lbGroupFactor.MultiColumn = true;

            dGVGroupFactor.RowCount = ListGroupFactor.Count + 1;
            dGVGroupFactor.ColumnCount = ListGroupFactor.Count;
            dGVGroupFactor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < ListGroupFactor.Count; i++)
            {
                DataGridViewComboBoxColumn values1 = new DataGridViewComboBoxColumn();
                values1.Items.AddRange(valuesGroup.ToArray());
                dGVGroupFactor.Columns.Insert(i, values1);
                dGVGroupFactor.Columns.RemoveAt(ListGroupFactor.Count);
                dGVGroupFactor.Rows[i].Cells[i].Value = "1";
                dGVGroupFactor.AllowUserToAddRows = false;
            }

        }

        public double[] mainVectorArray()
        {
            double[] sum = new double[ListGroupFactor.Count];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = 1;
            }

            for (int i = 0; i < ListGroupFactor.Count; i++)
            {
                for (int j = 0; j < ListGroupFactor.Count; j++)
                {
                    sum[i] *= PrioritiesGroupFactor[i, j];
                }
                sum[i] = Math.Pow(sum[i], (double) 1 / ListGroupFactor.Count);
            }
            return sum;
        }

        private void bReadyGroupFactor_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ListGroupFactor.Count; i++)
            {
                for (int j = 0; j < ListGroupFactor.Count; j++)
                {
                    if (Convert.ToDecimal(HelpFunctions.FractionToDouble(dGVGroupFactor[j, i].Value.ToString())) == 0)
                    {
                        MessageBox.Show("Заполните все поля!");
                        return;
                    }
                    else
                    {
                        PrioritiesGroupFactor[i, j] = HelpFunctions.FractionToDouble(dGVGroupFactor[j, i].Value.ToString());
                    }
                }
            }

            double[] sumVectorArray = mainVectorArray();
            double[] sumResultArray = new double[ListGroupFactor.Count];
            double sumMainVector = 0;

            dGVGroupFactor.Columns.Add("sumstr", "Вес");
            dGVGroupFactor.Columns[dGVGroupFactor.ColumnCount - 1].HeaderText = "Вес";
            dGVGroupFactor.Columns[dGVGroupFactor.ColumnCount - 1].Width = 90;

            for (int j = 0; j < ListGroupFactor.Count; j++)
            {
                sumMainVector += sumVectorArray[j];
            }

            for (int i = 0; i < ListGroupFactor.Count; i++)
            {
                sumResultArray[i] += sumVectorArray[i] / sumMainVector;
                dGVGroupFactor[dGVGroupFactor.ColumnCount - 1, i].Value = sumResultArray[i];
            }

            CalcFactor calcFactor = new CalcFactor(this, ListGroupFactor, sumResultArray);
        }

        private void CalcGroupFactor_Load(object sender, EventArgs e)
        {

        }

        private void dGVGroupFactor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string value = dGVGroupFactor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            for (int i = 0; i < ListGroupFactor.Count; i++)
            {
                for (int j = 0; j < ListGroupFactor.Count; j++)
                {
                    if (i != j)
                    {
                        if (value != "0" && value != "1")
                        {
                            dGVGroupFactor.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = valuesAutoFill[valuesAutoFill.Count - valuesAutoFill.IndexOf(value) - 1];
                        }
                        else if (value == "1")
                        {
                            dGVGroupFactor.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = "1";
                        }
                    }
                }
            }
        }
    }
}
