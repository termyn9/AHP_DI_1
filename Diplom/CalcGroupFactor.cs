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
        decimal[,] priorities;
        List<string> ListGroupFactor;
        List<string> valuesGroup = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "1/2", "1/3", "1/4", "1/5", "1/6", "1/7", "1/8", "1/9" }; 


        public CalcGroupFactor()
        {
            InitializeComponent();

            this.ListGroupFactor = lbGroupFactor.Items.Cast<String>().ToList();
            this.priorities = new decimal[ListGroupFactor.Count, ListGroupFactor.Count];

            dGVGroupFactor.RowCount = ListGroupFactor.Count;
            dGVGroupFactor.ColumnCount = ListGroupFactor.Count;
            dGVGroupFactor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            for (int i = 0; i < ListGroupFactor.Count; i++)
            {
                DataGridViewComboBoxColumn values1 = new DataGridViewComboBoxColumn();
                values1.Items.AddRange(valuesGroup.ToArray());
                dGVGroupFactor.Columns.Insert(i, values1);
                dGVGroupFactor.Columns.RemoveAt(ListGroupFactor.Count);
            }
        }

        private void bReadyGroupFactor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListGroupFactor.Count; i++)
            {
                for (int j = 0; j < ListGroupFactor.Count; j++)
                {
                    priorities[i, j] = Convert.ToDecimal(dGVGroupFactor[i, j].Value);
                }
            }
        }

        private void CalcGroupFactor_Load(object sender, EventArgs e)
        {

        }
    }
}
