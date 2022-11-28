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
    public partial class CharactersTypesClasses : Form
    {
        string[] ArrayClassText = { "Слабая защита", "Средняя защита", "Сильная защита", "Особая защита" };
        string[] ArrayCoeff = { "< 0.5", "0.5 - 0.74", "0.75 - 0.87", "> 0.88" };
        string[] ArrayClass = { "K1", "K2", "K3", "K4" };

        public CharactersTypesClasses()
        {
            InitializeComponent();
            dgvClassesTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < 4; i++)
            {
                dgvClassesTypes.Rows.Add();
                dgvClassesTypes.Rows[i].Cells[0].Value = ArrayClassText[i];
                dgvClassesTypes.Rows[i].Cells[1].Value = ArrayCoeff[i];
                dgvClassesTypes.Rows[i].Cells[2].Value = ArrayClass[i];
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
