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
    public partial class CharactersOfClass : Form
    {
        public CharactersOfClass(string classReq)
        {
            InitializeComponent();
            lClassSystem.Text = classReq;

            for (int i = 0; i < 5; i++)
            {
                ListViewItem req = new ListViewItem($"ИАФ.{(i + 1)}");
                lVRequirements.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                req.SubItems.Add(HelpFunctions.ListBoxRequirements[i]);
                lVRequirements.Items.Add(req);
            }
        }
    }
}
