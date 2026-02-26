namespace _2._26test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnClearReceive = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.label11);
            this.grpConnection.Controls.Add(this.txtReceive);
            this.grpConnection.Controls.Add(this.label10);
            this.grpConnection.Controls.Add(this.btnClearReceive);
            this.grpConnection.Controls.Add(this.lblStatus);
            this.grpConnection.Controls.Add(this.label9);
            this.grpConnection.Controls.Add(this.label8);
            this.grpConnection.Controls.Add(this.label7);
            this.grpConnection.Controls.Add(this.label6);
            this.grpConnection.Controls.Add(this.btnClose);
            this.grpConnection.Controls.Add(this.btnOpen);
            this.grpConnection.Controls.Add(this.btnRefresh);
            this.grpConnection.Controls.Add(this.label5);
            this.grpConnection.Controls.Add(this.label4);
            this.grpConnection.Controls.Add(this.label3);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Controls.Add(this.cmbParity);
            this.grpConnection.Controls.Add(this.cmbStopBits);
            this.grpConnection.Controls.Add(this.cmbDataBits);
            this.grpConnection.Controls.Add(this.cmbBaud);
            this.grpConnection.Controls.Add(this.cmbPort);
            this.grpConnection.Location = new System.Drawing.Point(12, 32);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(1572, 507);
            this.grpConnection.TabIndex = 10;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "groupBox1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(658, 326);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 18);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "状态显示";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "关闭";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "打开";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "刷新端口";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(661, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 39);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "button3";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(661, 165);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(175, 47);
            this.btnOpen.TabIndex = 21;
            this.btnOpen.Text = "button2";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(661, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(175, 47);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "button1";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "端口下拉框";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(199, 407);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(197, 26);
            this.cmbParity.TabIndex = 14;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(199, 323);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(197, 26);
            this.cmbStopBits.TabIndex = 13;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(199, 227);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(197, 26);
            this.cmbDataBits.TabIndex = 12;
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(199, 132);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(197, 26);
            this.cmbBaud.TabIndex = 11;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(199, 58);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(197, 26);
            this.cmbPort.TabIndex = 10;
            // 
            // btnClearReceive
            // 
            this.btnClearReceive.Location = new System.Drawing.Point(1100, 75);
            this.btnClearReceive.Name = "btnClearReceive";
            this.btnClearReceive.Size = new System.Drawing.Size(131, 47);
            this.btnClearReceive.TabIndex = 28;
            this.btnClearReceive.Text = "button1";
            this.btnClearReceive.UseVisualStyleBackColor = true;
            this.btnClearReceive.Click += new System.EventHandler(this.btnClearReceive_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1032, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "清除";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(1100, 152);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(466, 28);
            this.txtReceive.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1005, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "数据名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 694);
            this.Controls.Add(this.grpConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClearReceive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReceive;
    }
}

