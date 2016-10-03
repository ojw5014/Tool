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


        private Ojw.CStream m_CStream = new Ojw.CStream();
        private Label m_lbDisp = null;
        private void btnStartStreaming_Jpeg_Click(object sender, EventArgs e)
        {
            Form frmDisp = new Form();
            int nSize_Winddow_Height = 38;
            int nSize_Winddow_Width = 16;
            int nGap = 10;
            int nW = Ojw.CConvert.StrToInt(txtWidth.Text);
            int nH = Ojw.CConvert.StrToInt(txtHeight.Text);
            frmDisp.Owner = this;
            frmDisp.Width = nW + nSize_Winddow_Width + nGap * 2;
            frmDisp.Height = nH + nSize_Winddow_Height + nGap * 2 + 80;

            Label lbDisp = new Label();
            lbDisp.Left = nGap;
            lbDisp.Top = nGap;
            lbDisp.Width = nW;
            lbDisp.Height = nH;
            lbDisp.BackColor = Color.Gray;
            frmDisp.Controls.Add(lbDisp);
            m_lbDisp = lbDisp;

            Button btnStart = new Button();
            btnStart.Left = lbDisp.Left;
            btnStart.Top = nGap * 2 + lbDisp.Height;
            btnStart.Height = frmDisp.Height - nSize_Winddow_Height - btnStart.Top - nGap;
            btnStart.Width = (nW / 3 - nGap + nGap / 3);
            btnStart.Text = "Start(MJpeg)";
            btnStart.Click += new EventHandler(btnStart_Click);
            frmDisp.Controls.Add(btnStart);

            Button btnStart2 = new Button();
            btnStart2.Left = btnStart.Right + nGap;
            btnStart2.Top = nGap * 2 + lbDisp.Height;
            btnStart2.Height = frmDisp.Height - nSize_Winddow_Height - btnStart2.Top - nGap;
            btnStart2.Width = btnStart.Width;
            btnStart2.Text = "Start(Jpeg)";
            btnStart2.Click += new EventHandler(btnStart2_Click);
            frmDisp.Controls.Add(btnStart2);

            Button btnStop = new Button();
            btnStop.Left = btnStart2.Right + nGap;
            btnStop.Top = nGap * 2 + lbDisp.Height;
            btnStop.Height = frmDisp.Height - nSize_Winddow_Height - btnStop.Top - nGap;
            btnStop.Width = btnStart.Width;
            btnStop.Text = "Stop";
            btnStop.Click += new EventHandler(btnStop_Click);
            frmDisp.Controls.Add(btnStop);
            frmDisp.FormClosing += new FormClosingEventHandler(frmDisp_FormClosing);
            frmDisp.Show();   
        }
        void frmDisp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_CStream.IsStreaming == true) m_CStream.Stop();
        }

        void btnStart_Click(object sender, EventArgs e)
        {
            String strIp = txtIp.Text;
            int nPort = Ojw.CConvert.StrToInt(txtPort.Text);
            int nX = 0;
            int nY = 0;
            int nWidth = Ojw.CConvert.StrToInt(txtWidth.Text);
            int nHeight = Ojw.CConvert.StrToInt(txtHeight.Text);
            m_CStream.Start_MJpeg(m_lbDisp, strIp, nPort, nX, nY, nWidth, nHeight);
        }
        void btnStart2_Click(object sender, EventArgs e)
        {
            String strIp = txtIp.Text;
            int nPort = Ojw.CConvert.StrToInt(txtPort.Text);
            int nX = 0;
            int nY = 0;
            int nWidth = Ojw.CConvert.StrToInt(txtWidth.Text);
            int nHeight = Ojw.CConvert.StrToInt(txtHeight.Text);
            m_CStream.Start_Jpeg(m_lbDisp, strIp, nPort, nX, nY, nWidth, nHeight);
        }
        void btnStop_Click(object sender, EventArgs e)
        {
            m_CStream.Stop();
        }

        private Timer m_tmrJoystick = new Timer();
        private Ojw.CTimer m_CTmr_Joystick = new Ojw.CTimer(); // 조이스틱의 연결을 주기적으로 체크할 타이머
        private void chkJoystick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJoystick.Checked == true)
            {
                m_tmrJoystick.Interval = 100;
                m_btmrJoystick = false;
                m_tmrJoystick.Tick += new EventHandler(m_tmrJoystick_Tick);
                m_tmrJoystick.Enabled = true;
            }
            else
            {
                m_tmrJoystick.Enabled = false;
                m_btmrJoystick = true;
                m_tmrJoystick.Tick -= new EventHandler(m_tmrJoystick_Tick);
            }
        }


        private void FJoystick_Check_Alive()
        {
            #region Joystick Check

            Color m_colorLive = Color.LightGreen; // 살았을 경우의 색
            Color m_colorDead = Color.Gray; // 죽었을 경우의 색
            if (m_CJoy.IsValid == false)
            {
                #region 조이스틱이 연결되지 않았음을 표시
                if (lbJoystick.ForeColor != m_colorDead)
                {
                    lbJoystick.Text = "Joystick (No Connected)";
                    lbJoystick.ForeColor = m_colorDead;
                }
                #endregion 조이스틱이 연결되지 않았음을 표시

                #region 3초마다 다시 재연결을 하려고 시도
                if (m_CTmr_Joystick.Get() > 3000) // Joystic 이 죽어있다면 체크(3초단위)
                {
                    Ojw.CMessage.Write("Joystick Check again");
                    m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

                    if (m_CJoy.IsValid == false)
                    {
                        Ojw.CMessage.Write("But we can't find a joystick device in here. Check your joystick device");
                        m_CTmr_Joystick.Set(); // 타이머의 카운터를 다시 초기화 한다.
                    }
                    else Ojw.CMessage.Write("Joystick is Connected");
                }
                #endregion 3초마다 다시 재연결을 하려고 시도
            }
            else
            {
                #region 연결 되었음을 표시
                if (lbJoystick.ForeColor != m_colorLive)
                {
                    lbJoystick.Text = "Joystick (Connected)";
                    lbJoystick.ForeColor = m_colorLive;
                }
                #endregion 연결 되었음을 표시
            }
            #endregion Joystick Check
        }

        private Ojw.CJoystick m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0); // 조이스틱 선언

        private bool m_btmrJoystick = false;
        private void m_tmrJoystick_Tick(object sender, EventArgs e)
        {
            if (m_btmrJoystick == true) return;
            m_btmrJoystick = true;

            // 조이스틱 정보 갱신
            m_CJoy.Update();

            FJoystick_Check_Alive();
            FJoystick_Check_Data();

            m_btmrJoystick = false;
        }
        private void FJoystick_Check_Data()
        {
            #region JoyStick
            if (m_CJoy.IsValid == true)
            {
                #region Button
                for (int i = 1; i < (int)Enum.GetValues(typeof(Ojw.CJoystick.PadKey)).Length; i++)
                {
                    if (m_CJoy.IsDown_Event((Ojw.CJoystick.PadKey)i) == true) Ojw.CMessage.Write(txtEvent, "{0} Button : Clicked", i);
                }
                //foreach (Ojw.CJoystick.PadKey i in Enum.GetValues(typeof(Ojw.CJoystick.PadKey)).Length)
                //{
                //    if (m_CJoy.IsDown_Event(i) == true) Ojw.CMessage.Write(txtEvent, "{0} Button : Clicked", i);
                //}                
                #endregion Button

                #region 조이스틱
                for (int i = 0; i < 6; i++) ((Label)(this.Controls.Find(String.Format("lbData{0}", i), true)[0])).Text = Ojw.CConvert.DoubleToStr(m_CJoy.GetPos(i));
                #endregion 조이스틱
            }
            #endregion JoyStick
        }
    }
}
