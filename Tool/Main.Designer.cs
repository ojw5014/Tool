namespace Tool
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnMotionTool = new System.Windows.Forms.Button();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.btn3D_Full = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkApplicationExit = new System.Windows.Forms.CheckBox();
            this.btnVirtualKeyboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpacity = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStartStreaming_Jpeg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbJoystick = new System.Windows.Forms.Label();
            this.grpJoystick = new System.Windows.Forms.GroupBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.lbData5 = new System.Windows.Forms.Label();
            this.lbData4 = new System.Windows.Forms.Label();
            this.lbData3 = new System.Windows.Forms.Label();
            this.lbData2 = new System.Windows.Forms.Label();
            this.lbData1 = new System.Windows.Forms.Label();
            this.lbData0 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkJoystick = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpJoystick.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMotionTool
            // 
            this.btnMotionTool.Location = new System.Drawing.Point(14, 20);
            this.btnMotionTool.Name = "btnMotionTool";
            this.btnMotionTool.Size = new System.Drawing.Size(267, 59);
            this.btnMotionTool.TabIndex = 8;
            this.btnMotionTool.Text = "MotionEditor";
            this.btnMotionTool.UseVisualStyleBackColor = true;
            this.btnMotionTool.Click += new System.EventHandler(this.btnMotionTool_Click);
            // 
            // txtRatio
            // 
            this.txtRatio.Location = new System.Drawing.Point(219, 18);
            this.txtRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(63, 21);
            this.txtRatio.TabIndex = 6;
            this.txtRatio.Text = "1.0";
            this.txtRatio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRatio_MouseClick);
            // 
            // btn3D_Full
            // 
            this.btn3D_Full.Location = new System.Drawing.Point(14, 43);
            this.btn3D_Full.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3D_Full.Name = "btn3D_Full";
            this.btn3D_Full.Size = new System.Drawing.Size(267, 62);
            this.btn3D_Full.TabIndex = 4;
            this.btn3D_Full.Text = "3D Modeling Tool(Ratio)";
            this.btn3D_Full.UseVisualStyleBackColor = true;
            this.btn3D_Full.Click += new System.EventHandler(this.btn3D_Full_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modeling Tool Size(Default:1.0)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn3D_Full);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRatio);
            this.groupBox1.Location = new System.Drawing.Point(17, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3D Modeling Tool";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMotionTool);
            this.groupBox2.Location = new System.Drawing.Point(17, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(291, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motion Tool";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkApplicationExit);
            this.groupBox3.Controls.Add(this.btnVirtualKeyboard);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtOpacity);
            this.groupBox3.Location = new System.Drawing.Point(17, 224);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(291, 142);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Virtual Keyboard";
            // 
            // chkApplicationExit
            // 
            this.chkApplicationExit.AutoSize = true;
            this.chkApplicationExit.Location = new System.Drawing.Point(12, 47);
            this.chkApplicationExit.Name = "chkApplicationExit";
            this.chkApplicationExit.Size = new System.Drawing.Size(164, 16);
            this.chkApplicationExit.TabIndex = 10;
            this.chkApplicationExit.Text = "종료시 프로그램까지 종료";
            this.chkApplicationExit.UseVisualStyleBackColor = true;
            // 
            // btnVirtualKeyboard
            // 
            this.btnVirtualKeyboard.Location = new System.Drawing.Point(12, 69);
            this.btnVirtualKeyboard.Name = "btnVirtualKeyboard";
            this.btnVirtualKeyboard.Size = new System.Drawing.Size(267, 59);
            this.btnVirtualKeyboard.TabIndex = 8;
            this.btnVirtualKeyboard.Text = "Virtual Keyboard(한글 가상키보드)";
            this.btnVirtualKeyboard.UseVisualStyleBackColor = true;
            this.btnVirtualKeyboard.Click += new System.EventHandler(this.btnVirtualKeyboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set Opacity(투명도 설정 : Max = 1.0)";
            // 
            // txtOpacity
            // 
            this.txtOpacity.Location = new System.Drawing.Point(227, 16);
            this.txtOpacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpacity.Name = "txtOpacity";
            this.txtOpacity.Size = new System.Drawing.Size(52, 21);
            this.txtOpacity.TabIndex = 6;
            this.txtOpacity.Text = "0.7";
            this.txtOpacity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRatio_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStartStreaming_Jpeg);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtPort);
            this.groupBox4.Controls.Add(this.txtIp);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(314, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 354);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video Stream";
            // 
            // btnStartStreaming_Jpeg
            // 
            this.btnStartStreaming_Jpeg.Location = new System.Drawing.Point(14, 173);
            this.btnStartStreaming_Jpeg.Name = "btnStartStreaming_Jpeg";
            this.btnStartStreaming_Jpeg.Size = new System.Drawing.Size(127, 167);
            this.btnStartStreaming_Jpeg.TabIndex = 17;
            this.btnStartStreaming_Jpeg.Text = "Streaming Tool";
            this.btnStartStreaming_Jpeg.UseVisualStyleBackColor = true;
            this.btnStartStreaming_Jpeg.Click += new System.EventHandler(this.btnStartStreaming_Jpeg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(54, 133);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(87, 21);
            this.txtHeight.TabIndex = 15;
            this.txtHeight.Text = "480";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(54, 105);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(87, 21);
            this.txtWidth.TabIndex = 16;
            this.txtWidth.Text = "640";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Width";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(54, 56);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 21);
            this.txtPort.TabIndex = 14;
            this.txtPort.Text = "8081";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(54, 28);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(87, 21);
            this.txtIp.TabIndex = 13;
            this.txtIp.Text = "192.168.20.6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Height";
            // 
            // lbJoystick
            // 
            this.lbJoystick.AutoSize = true;
            this.lbJoystick.Location = new System.Drawing.Point(705, 25);
            this.lbJoystick.Name = "lbJoystick";
            this.lbJoystick.Size = new System.Drawing.Size(146, 12);
            this.lbJoystick.TabIndex = 15;
            this.lbJoystick.Text = "Joystick (No Connected)";
            // 
            // grpJoystick
            // 
            this.grpJoystick.Controls.Add(this.txtEvent);
            this.grpJoystick.Controls.Add(this.lbData5);
            this.grpJoystick.Controls.Add(this.lbData4);
            this.grpJoystick.Controls.Add(this.lbData3);
            this.grpJoystick.Controls.Add(this.lbData2);
            this.grpJoystick.Controls.Add(this.lbData1);
            this.grpJoystick.Controls.Add(this.lbData0);
            this.grpJoystick.Controls.Add(this.label11);
            this.grpJoystick.Controls.Add(this.label10);
            this.grpJoystick.Controls.Add(this.label9);
            this.grpJoystick.Controls.Add(this.label8);
            this.grpJoystick.Controls.Add(this.label7);
            this.grpJoystick.Controls.Add(this.label12);
            this.grpJoystick.Location = new System.Drawing.Point(473, 40);
            this.grpJoystick.Name = "grpJoystick";
            this.grpJoystick.Size = new System.Drawing.Size(389, 326);
            this.grpJoystick.TabIndex = 14;
            this.grpJoystick.TabStop = false;
            this.grpJoystick.Text = "Joystick";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(9, 67);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(369, 245);
            this.txtEvent.TabIndex = 11;
            // 
            // lbData5
            // 
            this.lbData5.AutoSize = true;
            this.lbData5.Location = new System.Drawing.Point(200, 53);
            this.lbData5.Name = "lbData5";
            this.lbData5.Size = new System.Drawing.Size(21, 12);
            this.lbData5.TabIndex = 4;
            this.lbData5.Text = "0.0";
            // 
            // lbData4
            // 
            this.lbData4.AutoSize = true;
            this.lbData4.Location = new System.Drawing.Point(200, 38);
            this.lbData4.Name = "lbData4";
            this.lbData4.Size = new System.Drawing.Size(21, 12);
            this.lbData4.TabIndex = 5;
            this.lbData4.Text = "0.0";
            // 
            // lbData3
            // 
            this.lbData3.AutoSize = true;
            this.lbData3.Location = new System.Drawing.Point(200, 23);
            this.lbData3.Name = "lbData3";
            this.lbData3.Size = new System.Drawing.Size(21, 12);
            this.lbData3.TabIndex = 6;
            this.lbData3.Text = "0.0";
            // 
            // lbData2
            // 
            this.lbData2.AutoSize = true;
            this.lbData2.Location = new System.Drawing.Point(59, 53);
            this.lbData2.Name = "lbData2";
            this.lbData2.Size = new System.Drawing.Size(21, 12);
            this.lbData2.TabIndex = 1;
            this.lbData2.Text = "0.0";
            // 
            // lbData1
            // 
            this.lbData1.AutoSize = true;
            this.lbData1.Location = new System.Drawing.Point(59, 38);
            this.lbData1.Name = "lbData1";
            this.lbData1.Size = new System.Drawing.Size(21, 12);
            this.lbData1.TabIndex = 2;
            this.lbData1.Text = "0.0";
            // 
            // lbData0
            // 
            this.lbData0.AutoSize = true;
            this.lbData0.Location = new System.Drawing.Point(59, 23);
            this.lbData0.Name = "lbData0";
            this.lbData0.Size = new System.Drawing.Size(21, 12);
            this.lbData0.TabIndex = 3;
            this.lbData0.Text = "0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Data5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Data3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Data1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Data0";
            // 
            // chkJoystick
            // 
            this.chkJoystick.AutoSize = true;
            this.chkJoystick.Location = new System.Drawing.Point(473, 19);
            this.chkJoystick.Name = "chkJoystick";
            this.chkJoystick.Size = new System.Drawing.Size(113, 16);
            this.chkJoystick.TabIndex = 13;
            this.chkJoystick.Text = "Enable Joystick";
            this.chkJoystick.UseVisualStyleBackColor = true;
            this.chkJoystick.CheckedChanged += new System.EventHandler(this.chkJoystick_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 378);
            this.Controls.Add(this.lbJoystick);
            this.Controls.Add(this.grpJoystick);
            this.Controls.Add(this.chkJoystick);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpJoystick.ResumeLayout(false);
            this.grpJoystick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMotionTool;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.Button btn3D_Full;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVirtualKeyboard;
        private System.Windows.Forms.CheckBox chkApplicationExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpacity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStartStreaming_Jpeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbJoystick;
        private System.Windows.Forms.GroupBox grpJoystick;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label lbData5;
        private System.Windows.Forms.Label lbData4;
        private System.Windows.Forms.Label lbData3;
        private System.Windows.Forms.Label lbData2;
        private System.Windows.Forms.Label lbData1;
        private System.Windows.Forms.Label lbData0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkJoystick;
    }
}

