using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace Tool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtRatio_MouseClick(object sender, MouseEventArgs e)
        {
            Ojw.ShowKeyPad_Number(sender);
        }

        private void btn3D_Full_Click(object sender, EventArgs e)
        {
            Ojw.CTools CTool = new Ojw.CTools();
            //CTool.ShowTools_Modeling();
            CTool.ShowTools_Modeling(Ojw.CConvert.StrToFloat(txtRatio.Text));
        }

        private void btnMotionTool_Click(object sender, EventArgs e)
        {
            Ojw.CTools_Motion CTool_Motion = new Ojw.CTools_Motion();
            CTool_Motion.ShowTools();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnVirtualKeyboard_Click(object sender, EventArgs e)
        {
            Ojw.CTools_Keyboard CKeyboard = new Ojw.CTools_Keyboard();
            CKeyboard.SetCloseEvent(chkApplicationExit.Checked);
            CKeyboard.SetOpacity(Ojw.CConvert.StrToDouble(txtOpacity.Text)); // 투명도 설정, 1.0 은 뚜렷이 보이는 것
            CKeyboard.ShowKeyboard();
        }
    }
}
