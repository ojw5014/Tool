namespace Tools
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
            this.btn3D = new System.Windows.Forms.Button();
            this.btn3D_Full = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStartStreaming_Jpeg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpJoystick = new System.Windows.Forms.GroupBox();
            this.rdJoystick1 = new System.Windows.Forms.RadioButton();
            this.rdJoystick0 = new System.Windows.Forms.RadioButton();
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
            this.label6 = new System.Windows.Forms.Label();
            this.chkJoystick = new System.Windows.Forms.CheckBox();
            this.lbJoystick = new System.Windows.Forms.Label();
            this.btnStreamServer_Start = new System.Windows.Forms.Button();
            this.btnStreamServer_Stop = new System.Windows.Forms.Button();
            this.btnStreamClient_Start = new System.Windows.Forms.Button();
            this.btnStreamClient_Stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStreamServer_Start_Camera2 = new System.Windows.Forms.Button();
            this.btnStreamServer_Start_Camera = new System.Windows.Forms.Button();
            this.txtStreamingServer_Height = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStreamingServer_Width = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStreamingServer_Port = new System.Windows.Forms.TextBox();
            this.btnCamera_Start = new System.Windows.Forms.Button();
            this.btnCamera_Stop = new System.Windows.Forms.Button();
            this.lbCamera = new System.Windows.Forms.Label();
            this.txtCameraIndex = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVoice = new System.Windows.Forms.Button();
            this.picDisp = new System.Windows.Forms.PictureBox();
            this.btnKeyboard_Global = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpJoystick.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3D
            // 
            this.btn3D.Location = new System.Drawing.Point(15, 11);
            this.btn3D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(96, 36);
            this.btn3D.TabIndex = 0;
            this.btn3D.Text = "3D Modeling Tool";
            this.btn3D.UseVisualStyleBackColor = true;
            this.btn3D.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // btn3D_Full
            // 
            this.btn3D_Full.Location = new System.Drawing.Point(117, 10);
            this.btn3D_Full.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3D_Full.Name = "btn3D_Full";
            this.btn3D_Full.Size = new System.Drawing.Size(96, 37);
            this.btn3D_Full.TabIndex = 0;
            this.btn3D_Full.Text = "3D Modeling Tool(Ratio)";
            this.btn3D_Full.UseVisualStyleBackColor = true;
            this.btn3D_Full.Click += new System.EventHandler(this.btn3D_Full_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ratio";
            // 
            // txtRatio
            // 
            this.txtRatio.Location = new System.Drawing.Point(66, 51);
            this.txtRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(55, 21);
            this.txtRatio.TabIndex = 2;
            this.txtRatio.Text = "1.0";
            this.txtRatio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRatio_MouseClick);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(156, 51);
            this.txtTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(55, 21);
            this.txtTest.TabIndex = 2;
            this.txtTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTest_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "MotionEditor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Virtual Keyboard(한글)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(58, 20);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(87, 21);
            this.txtIp.TabIndex = 7;
            this.txtIp.Text = "192.168.20.6";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(58, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 21);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "8081";
            // 
            // btnStartStreaming_Jpeg
            // 
            this.btnStartStreaming_Jpeg.Location = new System.Drawing.Point(6, 94);
            this.btnStartStreaming_Jpeg.Name = "btnStartStreaming_Jpeg";
            this.btnStartStreaming_Jpeg.Size = new System.Drawing.Size(184, 37);
            this.btnStartStreaming_Jpeg.TabIndex = 8;
            this.btnStartStreaming_Jpeg.Text = "Streaming Tool";
            this.btnStartStreaming_Jpeg.UseVisualStyleBackColor = true;
            this.btnStartStreaming_Jpeg.Click += new System.EventHandler(this.btnStartStreaming_Jpeg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(58, 70);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(41, 21);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.Text = "640";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(147, 70);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(41, 21);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.Text = "480";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartStreaming_Jpeg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(502, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Streaming From RaspberryPi (MJpeg)";
            // 
            // grpJoystick
            // 
            this.grpJoystick.Controls.Add(this.rdJoystick1);
            this.grpJoystick.Controls.Add(this.rdJoystick0);
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
            this.grpJoystick.Controls.Add(this.label6);
            this.grpJoystick.Location = new System.Drawing.Point(15, 488);
            this.grpJoystick.Name = "grpJoystick";
            this.grpJoystick.Size = new System.Drawing.Size(691, 115);
            this.grpJoystick.TabIndex = 10;
            this.grpJoystick.TabStop = false;
            this.grpJoystick.Text = "Joystick";
            // 
            // rdJoystick1
            // 
            this.rdJoystick1.AutoSize = true;
            this.rdJoystick1.Location = new System.Drawing.Point(95, 45);
            this.rdJoystick1.Name = "rdJoystick1";
            this.rdJoystick1.Size = new System.Drawing.Size(79, 16);
            this.rdJoystick1.TabIndex = 12;
            this.rdJoystick1.Text = "Joystick 1";
            this.rdJoystick1.UseVisualStyleBackColor = true;
            this.rdJoystick1.CheckedChanged += new System.EventHandler(this.rdJoystick1_CheckedChanged);
            // 
            // rdJoystick0
            // 
            this.rdJoystick0.AutoSize = true;
            this.rdJoystick0.Checked = true;
            this.rdJoystick0.Location = new System.Drawing.Point(95, 23);
            this.rdJoystick0.Name = "rdJoystick0";
            this.rdJoystick0.Size = new System.Drawing.Size(79, 16);
            this.rdJoystick0.TabIndex = 12;
            this.rdJoystick0.TabStop = true;
            this.rdJoystick0.Text = "Joystick 0";
            this.rdJoystick0.UseVisualStyleBackColor = true;
            this.rdJoystick0.CheckedChanged += new System.EventHandler(this.rdJoystick0_CheckedChanged);
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(193, 19);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(492, 91);
            this.txtEvent.TabIndex = 11;
            // 
            // lbData5
            // 
            this.lbData5.AutoSize = true;
            this.lbData5.Location = new System.Drawing.Point(59, 98);
            this.lbData5.Name = "lbData5";
            this.lbData5.Size = new System.Drawing.Size(21, 12);
            this.lbData5.TabIndex = 4;
            this.lbData5.Text = "0.0";
            // 
            // lbData4
            // 
            this.lbData4.AutoSize = true;
            this.lbData4.Location = new System.Drawing.Point(59, 83);
            this.lbData4.Name = "lbData4";
            this.lbData4.Size = new System.Drawing.Size(21, 12);
            this.lbData4.TabIndex = 5;
            this.lbData4.Text = "0.0";
            // 
            // lbData3
            // 
            this.lbData3.AutoSize = true;
            this.lbData3.Location = new System.Drawing.Point(59, 68);
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
            this.label11.Location = new System.Drawing.Point(7, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Data5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 68);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data0";
            // 
            // chkJoystick
            // 
            this.chkJoystick.AutoSize = true;
            this.chkJoystick.Location = new System.Drawing.Point(15, 471);
            this.chkJoystick.Name = "chkJoystick";
            this.chkJoystick.Size = new System.Drawing.Size(113, 16);
            this.chkJoystick.TabIndex = 7;
            this.chkJoystick.Text = "Enable Joystick";
            this.chkJoystick.UseVisualStyleBackColor = true;
            this.chkJoystick.CheckedChanged += new System.EventHandler(this.chkJoystick_CheckedChanged);
            // 
            // lbJoystick
            // 
            this.lbJoystick.AutoSize = true;
            this.lbJoystick.Location = new System.Drawing.Point(563, 477);
            this.lbJoystick.Name = "lbJoystick";
            this.lbJoystick.Size = new System.Drawing.Size(146, 12);
            this.lbJoystick.TabIndex = 11;
            this.lbJoystick.Text = "Joystick (No Connected)";
            // 
            // btnStreamServer_Start
            // 
            this.btnStreamServer_Start.Location = new System.Drawing.Point(143, 54);
            this.btnStreamServer_Start.Name = "btnStreamServer_Start";
            this.btnStreamServer_Start.Size = new System.Drawing.Size(134, 37);
            this.btnStreamServer_Start.TabIndex = 9;
            this.btnStreamServer_Start.Text = "Server Start(Screen)";
            this.btnStreamServer_Start.UseVisualStyleBackColor = true;
            this.btnStreamServer_Start.Click += new System.EventHandler(this.btnStreamServer_Start_Click);
            // 
            // btnStreamServer_Stop
            // 
            this.btnStreamServer_Stop.Location = new System.Drawing.Point(143, 94);
            this.btnStreamServer_Stop.Name = "btnStreamServer_Stop";
            this.btnStreamServer_Stop.Size = new System.Drawing.Size(134, 37);
            this.btnStreamServer_Stop.TabIndex = 9;
            this.btnStreamServer_Stop.Text = "Server Stop";
            this.btnStreamServer_Stop.UseVisualStyleBackColor = true;
            this.btnStreamServer_Stop.Click += new System.EventHandler(this.btnStreamServer_Stop_Click);
            // 
            // btnStreamClient_Start
            // 
            this.btnStreamClient_Start.Location = new System.Drawing.Point(9, 266);
            this.btnStreamClient_Start.Name = "btnStreamClient_Start";
            this.btnStreamClient_Start.Size = new System.Drawing.Size(150, 37);
            this.btnStreamClient_Start.TabIndex = 9;
            this.btnStreamClient_Start.Text = "Client Start";
            this.btnStreamClient_Start.UseVisualStyleBackColor = true;
            this.btnStreamClient_Start.Click += new System.EventHandler(this.btnStreamClient_Start_Click);
            // 
            // btnStreamClient_Stop
            // 
            this.btnStreamClient_Stop.Location = new System.Drawing.Point(179, 266);
            this.btnStreamClient_Stop.Name = "btnStreamClient_Stop";
            this.btnStreamClient_Stop.Size = new System.Drawing.Size(150, 37);
            this.btnStreamClient_Stop.TabIndex = 9;
            this.btnStreamClient_Stop.Text = "Client Stop";
            this.btnStreamClient_Stop.UseVisualStyleBackColor = true;
            this.btnStreamClient_Stop.Click += new System.EventHandler(this.btnStreamClient_Stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStreamServer_Start_Camera2);
            this.groupBox2.Controls.Add(this.btnStreamServer_Start_Camera);
            this.groupBox2.Controls.Add(this.btnStreamServer_Start);
            this.groupBox2.Controls.Add(this.btnStreamServer_Stop);
            this.groupBox2.Controls.Add(this.txtStreamingServer_Height);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtStreamingServer_Width);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtStreamingServer_Port);
            this.groupBox2.Location = new System.Drawing.Point(217, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 142);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Streaming Server / Client";
            // 
            // btnStreamServer_Start_Camera2
            // 
            this.btnStreamServer_Start_Camera2.Location = new System.Drawing.Point(6, 94);
            this.btnStreamServer_Start_Camera2.Name = "btnStreamServer_Start_Camera2";
            this.btnStreamServer_Start_Camera2.Size = new System.Drawing.Size(134, 37);
            this.btnStreamServer_Start_Camera2.TabIndex = 9;
            this.btnStreamServer_Start_Camera2.Text = "Server Start(Camera)";
            this.btnStreamServer_Start_Camera2.UseVisualStyleBackColor = true;
            this.btnStreamServer_Start_Camera2.Click += new System.EventHandler(this.btnStreamServer_Start_Camera2_Click);
            // 
            // btnStreamServer_Start_Camera
            // 
            this.btnStreamServer_Start_Camera.Location = new System.Drawing.Point(6, 54);
            this.btnStreamServer_Start_Camera.Name = "btnStreamServer_Start_Camera";
            this.btnStreamServer_Start_Camera.Size = new System.Drawing.Size(134, 37);
            this.btnStreamServer_Start_Camera.TabIndex = 9;
            this.btnStreamServer_Start_Camera.Text = "Server Start(Camera)";
            this.btnStreamServer_Start_Camera.UseVisualStyleBackColor = true;
            this.btnStreamServer_Start_Camera.Click += new System.EventHandler(this.btnStreamServer_Start_Camera_Click);
            // 
            // txtStreamingServer_Height
            // 
            this.txtStreamingServer_Height.Location = new System.Drawing.Point(237, 22);
            this.txtStreamingServer_Height.Name = "txtStreamingServer_Height";
            this.txtStreamingServer_Height.Size = new System.Drawing.Size(40, 21);
            this.txtStreamingServer_Height.TabIndex = 7;
            this.txtStreamingServer_Height.Text = "480";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "Height";
            // 
            // txtStreamingServer_Width
            // 
            this.txtStreamingServer_Width.Location = new System.Drawing.Point(145, 22);
            this.txtStreamingServer_Width.Name = "txtStreamingServer_Width";
            this.txtStreamingServer_Width.Size = new System.Drawing.Size(40, 21);
            this.txtStreamingServer_Width.TabIndex = 7;
            this.txtStreamingServer_Width.Text = "640";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(107, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "Width";
            // 
            // txtStreamingServer_Port
            // 
            this.txtStreamingServer_Port.Location = new System.Drawing.Point(44, 22);
            this.txtStreamingServer_Port.Name = "txtStreamingServer_Port";
            this.txtStreamingServer_Port.Size = new System.Drawing.Size(52, 21);
            this.txtStreamingServer_Port.TabIndex = 7;
            this.txtStreamingServer_Port.Text = "8081";
            // 
            // btnCamera_Start
            // 
            this.btnCamera_Start.Location = new System.Drawing.Point(226, 258);
            this.btnCamera_Start.Name = "btnCamera_Start";
            this.btnCamera_Start.Size = new System.Drawing.Size(106, 23);
            this.btnCamera_Start.TabIndex = 14;
            this.btnCamera_Start.Text = "Start(Camera)";
            this.btnCamera_Start.UseVisualStyleBackColor = true;
            this.btnCamera_Start.Click += new System.EventHandler(this.btnCamera_Start_Click);
            // 
            // btnCamera_Stop
            // 
            this.btnCamera_Stop.Location = new System.Drawing.Point(226, 281);
            this.btnCamera_Stop.Name = "btnCamera_Stop";
            this.btnCamera_Stop.Size = new System.Drawing.Size(106, 23);
            this.btnCamera_Stop.TabIndex = 14;
            this.btnCamera_Stop.Text = "Stop(Camera)";
            this.btnCamera_Stop.UseVisualStyleBackColor = true;
            this.btnCamera_Stop.Click += new System.EventHandler(this.btnCamera_Stop_Click);
            // 
            // lbCamera
            // 
            this.lbCamera.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbCamera.Location = new System.Drawing.Point(12, 17);
            this.lbCamera.Name = "lbCamera";
            this.lbCamera.Size = new System.Drawing.Size(320, 240);
            this.lbCamera.TabIndex = 15;
            this.lbCamera.Text = "label15";
            // 
            // txtCameraIndex
            // 
            this.txtCameraIndex.Location = new System.Drawing.Point(16, 282);
            this.txtCameraIndex.Name = "txtCameraIndex";
            this.txtCameraIndex.Size = new System.Drawing.Size(52, 21);
            this.txtCameraIndex.TabIndex = 7;
            this.txtCameraIndex.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 12);
            this.label15.TabIndex = 6;
            this.label15.Text = "Camera Index";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCamera);
            this.groupBox3.Controls.Add(this.txtCameraIndex);
            this.groupBox3.Controls.Add(this.btnCamera_Stop);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnCamera_Start);
            this.groupBox3.Location = new System.Drawing.Point(360, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 310);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera Device(Webcam)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picDisp);
            this.groupBox4.Controls.Add(this.btnStreamClient_Start);
            this.groupBox4.Controls.Add(this.btnStreamClient_Stop);
            this.groupBox4.Location = new System.Drawing.Point(15, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 310);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Streaming Server / Client(Streaming Image)";
            // 
            // btnVoice
            // 
            this.btnVoice.Location = new System.Drawing.Point(115, 77);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(96, 25);
            this.btnVoice.TabIndex = 3;
            this.btnVoice.Text = "Voice Recog";
            this.btnVoice.UseVisualStyleBackColor = true;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // picDisp
            // 
            this.picDisp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picDisp.Location = new System.Drawing.Point(9, 19);
            this.picDisp.Name = "picDisp";
            this.picDisp.Size = new System.Drawing.Size(320, 240);
            this.picDisp.TabIndex = 12;
            this.picDisp.TabStop = false;
            // 
            // btnKeyboard_Global
            // 
            this.btnKeyboard_Global.Location = new System.Drawing.Point(15, 127);
            this.btnKeyboard_Global.Name = "btnKeyboard_Global";
            this.btnKeyboard_Global.Size = new System.Drawing.Size(196, 25);
            this.btnKeyboard_Global.TabIndex = 4;
            this.btnKeyboard_Global.Text = "Virtual Keyboard(Global)";
            this.btnKeyboard_Global.UseVisualStyleBackColor = true;
            this.btnKeyboard_Global.Click += new System.EventHandler(this.btnKeyboard_Global_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 618);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbJoystick);
            this.Controls.Add(this.grpJoystick);
            this.Controls.Add(this.chkJoystick);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKeyboard_Global);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVoice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtRatio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3D_Full);
            this.Controls.Add(this.btn3D);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpJoystick.ResumeLayout(false);
            this.grpJoystick.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3D;
        private System.Windows.Forms.Button btn3D_Full;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStartStreaming_Jpeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpJoystick;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkJoystick;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label lbJoystick;
        private System.Windows.Forms.Button btnStreamServer_Stop;
        private System.Windows.Forms.Button btnStreamServer_Start;
        private System.Windows.Forms.PictureBox picDisp;
        private System.Windows.Forms.Button btnStreamClient_Start;
        private System.Windows.Forms.Button btnStreamClient_Stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStreamingServer_Height;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStreamingServer_Width;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStreamingServer_Port;
        private System.Windows.Forms.Button btnStreamServer_Start_Camera;
        private System.Windows.Forms.Button btnCamera_Start;
        private System.Windows.Forms.Button btnCamera_Stop;
        private System.Windows.Forms.Label lbCamera;
        private System.Windows.Forms.TextBox txtCameraIndex;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStreamServer_Start_Camera2;
        private System.Windows.Forms.RadioButton rdJoystick1;
        private System.Windows.Forms.RadioButton rdJoystick0;
        private System.Windows.Forms.Button btnVoice;
        private System.Windows.Forms.Button btnKeyboard_Global;
    }
}

