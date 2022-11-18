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
    public partial class Form1 : Form
    {
        Form FormGroupFactors;
        List<string> ListGroupFactors;
        double[] WeightsGroupFactros;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupOrFactor.SelectedIndex == 0)
            {
                CalcGroupFactor calcGroupFactor = new CalcGroupFactor();
                calcGroupFactor.Show();
            }
            else
            {
                CalcFactor calcFactor = new CalcFactor(FormGroupFactors, ListGroupFactors, WeightsGroupFactros);
                calcFactor.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbUserFunction.SelectedIndex == 0)
            {
                CalcCoeff calcCoeff = new CalcCoeff();
                calcCoeff.Show();
            }
        }

        private void cbDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDB.SelectedIndex == 0)
            {
                DBGroupFactors dBGroupFactors = new DBGroupFactors();
                dBGroupFactors.Show();
            }
        }
    }
}
