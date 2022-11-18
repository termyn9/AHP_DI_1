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
using System.ComponentModel.DataAnnotations;

namespace Diplom
{
    public partial class DBGroupFactors : Form
    {
        CoeffContext db;
        public DBGroupFactors()
        {
            InitializeComponent();

            db = new CoeffContext();
            db.Groups.Load();

            dgvDBGroupsFactor.DataSource = db.Groups.Local.ToBindingList();
            dgvDBGroupsFactor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDBGroupsFactor.AllowUserToAddRows = false;

        }
    }
}
