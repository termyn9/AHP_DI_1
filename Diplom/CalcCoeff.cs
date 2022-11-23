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
        int k = 0;

        double[] sumCoeffFactorWeight = new double[3];
        List<double> resultCoeff = new List<double>();

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

        private void bCalculateCoeff_Click(object sender, EventArgs e)
        {
            // Расчет коэффициента защищенности //
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultCoeff.Add(arrayValueRB[k] * Convert.ToDouble(dgvFactorsWatch.Rows[j].Cells[4].Value) * Convert.ToDouble(dgvGroupFactorsWatch.Rows[i].Cells[3].Value));
                    k++;
                }
            }

            double W = resultCoeff.Sum(x => Convert.ToDouble(x));
            ResultForm resultForm = new ResultForm(W);
            resultForm.Show();

            // Расчет коэффициента конкордации // 
            string searchValue = "1";
            List<int> indexFirstGroup = new List<int>();

            foreach (DataGridViewRow row in dgvGroupFactorsWatch.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    indexFirstGroup.Add(row.Index);
                }
            }

            double[] S = new double[5];
            for (int i = 0; i < dgvGroupFactorsWatch.Rows.Count; i++)
            {
                S[i]
            }
        }
    }
}
