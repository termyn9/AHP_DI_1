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

        private void группыФакторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcGroupFactor calcGroupFactor = new CalcGroupFactor();
            calcGroupFactor.Show();
        }

        private void факторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcFactor calcFactor = new CalcFactor(FormGroupFactors, ListGroupFactors, WeightsGroupFactros);
            calcFactor.Show();
        }

        private void рассчитатьКоэффициентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcCoeff calcCoeff = new CalcCoeff();
            calcCoeff.Show();
        }

        private void группыФакторовToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DBGroupFactors dBGroupFactors = new DBGroupFactors();
            dBGroupFactors.Show();
        }

        private void факторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBFactors dBFactors = new DBFactors();
            dBFactors.Show();
        }

        private void харкиТиповыхСЗИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharactersTypesClasses charactersTypesClasses = new CharactersTypesClasses();
            charactersTypesClasses.Show();
        }

        private void требованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharactersOfClass charactersOfClass = new CharactersOfClass("K2");
            charactersOfClass.Show();
        }
    }
}
