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
    public partial class CalcFactor : Form
    {
        Form FormGroupFactors;
        List<string> ValuesAutoFill;
        List<string> ValuesGroup;
        List<string> ListGroupFactors;
        decimal[] WeightsGroupFactros;

        public CalcFactor(Form calcGroupFactor, List<string> valuesAutoFill, List<string> valuesGroup, List<string> ListGroupFactor, decimal[] sumResultArray)
        {
            InitializeComponent();
            this.FormGroupFactors = calcGroupFactor;
            this.ValuesAutoFill = valuesAutoFill;
            this.ValuesGroup = valuesGroup;
            this.ListGroupFactors = ListGroupFactor;
            this.WeightsGroupFactros = sumResultArray;
        }
    }
}
