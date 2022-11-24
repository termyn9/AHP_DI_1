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

            if (W > 0.88)
            {
                lClassDef.Text = "K1";
                lLevelDef.Text = "Особой защиты";
            } else if (W > 0.74 && W <= 0.88)
            {
                lClassDef.Text = "K2";
                lLevelDef.Text = "Сильной защиты";

            } else if (W >= 0.5 && W <= 0.74)
            {
                lClassDef.Text = "K3";
                lLevelDef.Text = "Средней защиты";
            }
            else 
            { 
                lClassDef.Text = "K4";
                lLevelDef.Text = "Слабой защиты";
            }
        }
    }
}
