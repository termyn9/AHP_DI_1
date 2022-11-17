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
    public partial class CalcFactor : Form
    {
        Form FormGroupFactors;
        List<string> ValuesAutoFill = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "1/9", "1/8", "1/7", "1/6", "1/5", "1/4", "1/3", "1/2" };
        List<string> ValuesGroup = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "1/2", "1/3", "1/4", "1/5", "1/6", "1/7", "1/8", "1/9" };
        List<string> ListGroupFactors;
        double[] WeightsGroupFactors;

        List<string> ListFactors;
        double[,] PrioritiesFactors;

        public CalcFactor(Form calcGroupFactor, List<string> ListGroupFactor, double[] sumResultArray)
        {
            InitializeComponent();
            this.FormGroupFactors = calcGroupFactor;
            this.ListGroupFactors = ListGroupFactor;
            this.WeightsGroupFactors = sumResultArray;

            this.ListFactors = lbFactors.Items.Cast<String>().ToList();
            lbFactors.MultiColumn = true;

            this.PrioritiesFactors = new double[ListFactors.Count, ListFactors.Count];


            dGVFactors.RowCount = ListFactors.Count + 1;
            dGVFactors.ColumnCount = ListFactors.Count;
            dGVFactors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < ListFactors.Count; i++)
            {
                DataGridViewComboBoxColumn values1 = new DataGridViewComboBoxColumn();
                values1.Items.AddRange(ValuesGroup.ToArray());
                dGVFactors.Columns.Insert(i, values1);
                dGVFactors.Columns.RemoveAt(ListFactors.Count);
                dGVFactors.Rows[i].Cells[i].Value = "1";
                dGVFactors.AllowUserToAddRows = false;
            }


        }

        private void dGVFactors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string value = dGVFactors.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            for (int i = 0; i < ListFactors.Count; i++)
            {
                for (int j = 0; j < ListFactors.Count; j++)
                {
                    if (i != j)
                    {
                        if (value != "0" && value != "1")
                        {
                            dGVFactors.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = ValuesAutoFill[ValuesAutoFill.Count - ValuesAutoFill.IndexOf(value) - 1];
                        }
                        else if (value == "1")
                        {
                            dGVFactors.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = "1";
                        }
                    }
                }
            }
        }

        public double[] mainVectorArray()
        {
            double[] sum = new double[ListFactors.Count];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = 1;
            }

            for (int i = 0; i < ListFactors.Count; i++)
            {
                for (int j = 0; j < ListFactors.Count; j++)
                {
                    sum[i] *= PrioritiesFactors[i, j];
                }
                sum[i] = Math.Pow(sum[i], (double)1 / ListFactors.Count);
            }
            return sum;
        }

        private void bReadyFactors_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListFactors.Count; i++)
            {
                for (int j = 0; j < ListFactors.Count; j++)
                {
                    if (Convert.ToDecimal(HelpFunctions.FractionToDouble(dGVFactors[j, i].Value.ToString())) == 0)
                    {
                        MessageBox.Show("Заполните все поля!");
                        return;
                    }
                    else
                    {
                        PrioritiesFactors[i, j] = HelpFunctions.FractionToDouble(dGVFactors[j, i].Value.ToString());
                    }
                }
            }

            double[] sumVectorArray = mainVectorArray();
            double[] sumResultArray = new double[ListFactors.Count];
            double sumMainVector = 0;

            dGVFactors.Columns.Add("sumstr", "Вес");
            dGVFactors.Columns[dGVFactors.ColumnCount - 1].HeaderText = "Вес";
            dGVFactors.Columns[dGVFactors.ColumnCount - 1].Width = 70;

            for (int j = 0; j < ListFactors.Count; j++)
            {
                sumMainVector += sumVectorArray[j];
            }

            for (int i = 0; i < ListFactors.Count; i++)
            {
                sumResultArray[i] += sumVectorArray[i] / sumMainVector;
                dGVFactors[dGVFactors.ColumnCount - 1, i].Value = sumResultArray[i];
            }
        }
    }
}
