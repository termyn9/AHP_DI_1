﻿using System;
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
    public partial class ResultForm : Form
    {
        public ResultForm(double W)
        {
            InitializeComponent();
            lW.Text = W.ToString();
        }
    }
}
