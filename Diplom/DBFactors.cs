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
    public partial class DBFactors : Form
    {
        CoeffContext db;
        public DBFactors()
        {
            InitializeComponent();

            db = new CoeffContext();
            db.Factors.Load();

            dgvFactors.DataSource = db.Factors.Local.ToBindingList();
            dgvFactors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactors.AllowUserToAddRows = false;
        }
    }
}
