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
            ListFactors = lbFactor.Items.Cast<String>().ToList();

            //int countAllFactorsDB = dgvGroupFactorsWatch.Rows.Count;
            //int countAllGroupFactorsDB = dgvGroupFactorsWatch.Rows.Count;

            lbGroupFactors.SetSelected(0, true);
            lbFactor.SetSelected(0, true);

            rbVeryHigh.Checked = true;

            db = new CoeffContext();
            db.Factors.Load();
            dgvFactorsWatch.DataSource = db.Factors.Local.ToBindingList();
            db.Groups.Load();
            dgvGroupFactorsWatch.DataSource = db.Groups.Local.ToBindingList();
        }

        private void lbGroupFactors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bReady_Click(object sender, EventArgs e)
        {
            if (countFactor == ListFactors.Count - 1 && countGroup != ListGroupFactors.Count - 1)
            {
                countGroup++;
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

            double[] S = new double[5];

            List<double> WeightOfGroup = new List<double>();
            for (int count = 0; count < dgvGroupFactorsWatch.Rows.Count / 5; count++)
            {
                for (int i = 0; i < 5; i++)
                {
                    WeightOfGroup.Add(Convert.ToDouble(dgvGroupFactorsWatch.Rows[i].Cells[3].Value));
                }
                double maxValue = WeightOfGroup.Max();
                S[1] = WeightOfGroup.IndexOf(maxValue) + 1;
            }

            for (int i = 0; i < dgvGroupFactorsWatch.Rows.Count; i++)
            {
            }
        }
    }
}
