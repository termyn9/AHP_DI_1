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
    public partial class CalcCoeff : Form
    {
        List<string> ListGroupFactors;
        List<string> ListFactors;
        int countGroup = 0;
        int countFactor = 0;
        int count = 1;
        double valueRB = 0;
        double W_all = 0;

        double[] sumCoeffFactorWeight = new double[3];

        List<double> arrayW = new List<double>();
        List<double> arrayValueRB = new List<double>();

        CoeffContext db;

        public CalcCoeff()
        {
            InitializeComponent();
            ListGroupFactors = lbGroupFactors.Items.Cast<String>().ToList();

            lbFactor.Items.Add(HelpFunctions.ListBoxFactors[0]);
            lbFactor.Items.Add(HelpFunctions.ListBoxFactors[1]);
            lbFactor.Items.Add(HelpFunctions.ListBoxFactors[2]);

            ListFactors = lbFactor.Items.Cast<String>().ToList();

            lbGroupFactors.SetSelected(0, true);
            lbFactor.SetSelected(0, true);

            rbVeryHigh.Checked = true;

            db = new CoeffContext();
            db.Factors.Load();
            dgvFactorsWatch.DataSource = db.Factors.Local.ToBindingList();
            db.Groups.Load();
            dgvGroupFactorsWatch.DataSource = db.Groups.Local.ToBindingList();

            rbVeryHigh.Text = HelpFunctions.ListBoxValuesFactors[0];
            rbHigh.Text = HelpFunctions.ListBoxValuesFactors[1];
            rbMedium.Text = HelpFunctions.ListBoxValuesFactors[2];
            rbLow.Text = HelpFunctions.ListBoxValuesFactors[3];
        }

        private void lbGroupFactors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bReady_Click(object sender, EventArgs e)
        {
            if (countFactor == ListFactors.Count - 1 && countGroup != ListGroupFactors.Count - 1)
            {
                countGroup++;
                for (int i = 0; i < 3; i++)
                {
                    lbFactor.Items.RemoveAt(0);
                    lbFactor.Items.Add(HelpFunctions.ListBoxFactors[i + countGroup * 3]);
                }
                lbGroupFactors.SetSelected(countGroup, true);
                countFactor = 0;
                lbFactor.SetSelected(countFactor, true);
            }
            else if (countFactor == ListFactors.Count - 1 && countGroup == ListGroupFactors.Count - 1)
            {
                MessageBox.Show("Показания для расчета коэффициента введены!");
            }
            else
            {
                countFactor++;
                lbFactor.SetSelected(countFactor, true);
            }

            if (count == 15)
            {
                count = 0;
            }
            else
            {
                rbVeryHigh.Text = HelpFunctions.ListBoxValuesFactors[0 + count * 4];
                rbHigh.Text = HelpFunctions.ListBoxValuesFactors[1 + count * 4];
                rbMedium.Text = HelpFunctions.ListBoxValuesFactors[2 + count * 4];
                rbLow.Text = HelpFunctions.ListBoxValuesFactors[3 + count * 4];
                count++;
            }

            if (rbVeryHigh.Checked) { valueRB = 1; }
            else if (rbHigh.Checked) { valueRB = 0.75; }
            else if (rbMedium.Checked) { valueRB = 0.5; }
            else { valueRB = 0.25; }

            arrayValueRB.Add(valueRB);
            if (arrayValueRB.Count == 15)
            {
                bReady.Visible = false;
                bCalculateCoeff.Visible = true;
            }
        }

        public double CoeffOf5Rows(int i_W, int j_W)
        {
            int k = 0;
            double W = 0;
            List<double> resultCoeff = new List<double>();
            for (int i = i_W; i < i_W + 5; i++)
            {
                for (int j = j_W; j < j_W + 3; j++)
                {
                    resultCoeff.Add(arrayValueRB[k] * Convert.ToDouble(dgvFactorsWatch.Rows[j].Cells[4].Value) * Convert.ToDouble(dgvGroupFactorsWatch.Rows[i].Cells[3].Value));
                    k++;
                }
                j_W += 3;
            }
            return W = resultCoeff.Sum(x => Convert.ToDouble(x));
        }

        private void bCalculateCoeff_Click(object sender, EventArgs e)
        {
            // Расчет коэффициента защищенности //

            string searchValue = "1";
            List<int> indexFirstGroup = new List<int>();

            foreach (DataGridViewRow row in dgvGroupFactorsWatch.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    indexFirstGroup.Add(row.Index);
                }
            }


            for (int i = 0; i < dgvGroupFactorsWatch.Rows.Count; i++)
            {
                for (int j = 0; j < indexFirstGroup.Count; j++)
                {
                    if (i == indexFirstGroup[j])
                    {
                        arrayW.Add(CoeffOf5Rows(i, i * 3));
                    }
                }
            }

            W_all = arrayW.Sum(x => Convert.ToDouble(x)) / arrayW.Count;
            ResultForm resultForm = new ResultForm(W_all);
            resultForm.Show();


            // Расчет коэффициента конкордации // 

            double[,] S_Range = new double[5, dgvGroupFactorsWatch.Rows.Count / 5];
            double[] S_Factor = new double[5];
            double S_Result = 0;
            double W = 0;
            List<double> WeightOfGroup = new List<double>();
            double maxValue = 0;

            for (int count = 0; count < dgvGroupFactorsWatch.Rows.Count / 5; count++)
            {
                for (int i = count * 5; i < (count + 1) * 5; i++)
                {
                    WeightOfGroup.Add(Convert.ToDouble(dgvGroupFactorsWatch.Rows[i].Cells[3].Value));
                }

                for (int j = 0; j < 5; j++)
                {
                    maxValue = WeightOfGroup.Max();
                    S_Range[j, count] = WeightOfGroup.IndexOf(maxValue) + 1;
                    WeightOfGroup[WeightOfGroup.IndexOf(maxValue)] = 0;
                }

                for (int i = 0; i < 5; i++)
                {
                    WeightOfGroup.RemoveAt(0);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < dgvGroupFactorsWatch.Rows.Count / 5; j++)
                {
                    S_Factor[i] += S_Range[i, j];
                }
            }


            int M = dgvGroupFactorsWatch.Rows.Count / 5;
            int A = M * (5 + 1) / 2;
            for (int i = 0; i < 5; i++)
            {
                S_Result += (S_Factor[i] - A) * (S_Factor[i] - A);
            }

            W = (12 * S_Result) / (M * M * 5 * (5 * 5 - 1));
            tbCoeffConcord.Text = Math.Round(W, 4).ToString();
        }
    }
}
