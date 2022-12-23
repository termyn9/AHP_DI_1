using MaterialSkin;
using MaterialSkin.Controls;
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

            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            lClassSystem.Text = classReq;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(1, 45);
            lVRequirements.SmallImageList = imageList;
        }
    }
}
