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
    public partial class CalcCoeff : Form
    {
        List<string> ListGroupFactors;
        List<string> ListFactors;
        int countGroup = 0;
        int countFactor = 0;
        double valueRB = 0;

        public CalcCoeff()
        {
            InitializeComponent();
            ListGroupFactors = lbGroupFactors.Items.Cast<String>().ToList();
            ListFactors = lbFactor.Items.Cast<String>().ToList();

            lbGroupFactors.SetSelected(0, true);
            lbFactor.SetSelected(0, true);

            rbVeryHigh.Checked = true;
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
                ResultForm resultForm = new ResultForm();
                resultForm.Show();
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
        }
    }
}
