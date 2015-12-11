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
            this.btnMotionTool = new System.Windows.Forms.Button();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.btn3D_Full = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMotionTool
            // 
            this.btnMotionTool.Location = new System.Drawing.Point(16, 25);
            this.btnMotionTool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMotionTool.Name = "btnMotionTool";
            this.btnMotionTool.Size = new System.Drawing.Size(305, 74);
            this.btnMotionTool.TabIndex = 8;
            this.btnMotionTool.Text = "MotionEditor";
            this.btnMotionTool.UseVisualStyleBackColor = true;
            this.btnMotionTool.Click += new System.EventHandler(this.btnMotionTool_Click);
            // 
            // txtRatio
            // 
            this.txtRatio.Location = new System.Drawing.Point(250, 23);
            this.txtRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(71, 25);
            this.txtRatio.TabIndex = 6;
            this.txtRatio.Text = "1.0";
            this.txtRatio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRatio_MouseClick);
            // 
            // btn3D_Full
            // 
            this.btn3D_Full.Location = new System.Drawing.Point(16, 54);
            this.btn3D_Full.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3D_Full.Name = "btn3D_Full";
            this.btn3D_Full.Size = new System.Drawing.Size(305, 78);
            this.btn3D_Full.TabIndex = 4;
            this.btn3D_Full.Text = "3D Modeling Tool(Ratio)";
            this.btn3D_Full.UseVisualStyleBackColor = true;
            this.btn3D_Full.Click += new System.EventHandler(this.btn3D_Full_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modeling Tool Size(Default:1.0)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn3D_Full);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRatio);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 146);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3D Modeling Tool";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMotionTool);
            this.groupBox2.Location = new System.Drawing.Point(19, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motion Tool";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMotionTool;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.Button btn3D_Full;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

