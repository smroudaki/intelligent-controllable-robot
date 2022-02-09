namespace IntelligentControllableRobot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPortSelect = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIR = new System.Windows.Forms.Button();
            this.btnUltraSonic = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trackBarTurningDegree = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurningDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.cmbBaudRate);
            this.groupBox2.Controls.Add(this.cmbPortSelect);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(69, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 688);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Italic);
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.Location = new System.Drawing.Point(479, 117);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 95);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Ref";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaudRate.ForeColor = System.Drawing.Color.Gray;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(92, 173);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(352, 39);
            this.cmbBaudRate.TabIndex = 1;
            this.cmbBaudRate.Text = "Baud Rate";
            this.cmbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cmbBaudRate_SelectedIndexChanged);
            // 
            // cmbPortSelect
            // 
            this.cmbPortSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPortSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPortSelect.ForeColor = System.Drawing.Color.Gray;
            this.cmbPortSelect.FormattingEnabled = true;
            this.cmbPortSelect.Location = new System.Drawing.Point(92, 117);
            this.cmbPortSelect.Name = "cmbPortSelect";
            this.cmbPortSelect.Size = new System.Drawing.Size(352, 39);
            this.cmbPortSelect.TabIndex = 0;
            this.cmbPortSelect.Text = "Port Select";
            this.cmbPortSelect.SelectedIndexChanged += new System.EventHandler(this.cmbPortSelect_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(92, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(485, 65);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.Transparent;
            this.btnConnect.Location = new System.Drawing.Point(92, 313);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(485, 65);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.Location = new System.Drawing.Point(92, 391);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(485, 65);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIR);
            this.groupBox1.Controls.Add(this.btnUltraSonic);
            this.groupBox1.Controls.Add(this.btnOff);
            this.groupBox1.Controls.Add(this.btnBottomLeft);
            this.groupBox1.Controls.Add(this.btnBottomRight);
            this.groupBox1.Controls.Add(this.btnTopLeft);
            this.groupBox1.Controls.Add(this.btnTopRight);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnForward);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnBackward);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(807, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 688);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controller";
            // 
            // btnIR
            // 
            this.btnIR.BackColor = System.Drawing.Color.Transparent;
            this.btnIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIR.ForeColor = System.Drawing.Color.Firebrick;
            this.btnIR.Location = new System.Drawing.Point(828, 66);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(91, 51);
            this.btnIR.TabIndex = 16;
            this.btnIR.TabStop = false;
            this.btnIR.Text = "IR";
            this.btnIR.UseVisualStyleBackColor = false;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // btnUltraSonic
            // 
            this.btnUltraSonic.BackColor = System.Drawing.Color.Transparent;
            this.btnUltraSonic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltraSonic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltraSonic.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUltraSonic.Location = new System.Drawing.Point(722, 66);
            this.btnUltraSonic.Name = "btnUltraSonic";
            this.btnUltraSonic.Size = new System.Drawing.Size(91, 51);
            this.btnUltraSonic.TabIndex = 15;
            this.btnUltraSonic.TabStop = false;
            this.btnUltraSonic.Text = "U";
            this.btnUltraSonic.UseVisualStyleBackColor = false;
            this.btnUltraSonic.Click += new System.EventHandler(this.btnUltraSonic_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Transparent;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Italic);
            this.btnOff.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnOff.Location = new System.Drawing.Point(367, 312);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(313, 153);
            this.btnOff.TabIndex = 6;
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOff_KeyDown);
            this.btnOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnOff_KeyPress);
            this.btnOff.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnOff_KeyUp);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic);
            this.btnBottomLeft.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBottomLeft.Location = new System.Drawing.Point(131, 451);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(306, 153);
            this.btnBottomLeft.TabIndex = 12;
            this.btnBottomLeft.TabStop = false;
            this.btnBottomLeft.Text = "Z";
            this.btnBottomLeft.UseVisualStyleBackColor = false;
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.btnBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic);
            this.btnBottomRight.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBottomRight.Location = new System.Drawing.Point(613, 451);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(306, 153);
            this.btnBottomRight.TabIndex = 14;
            this.btnBottomRight.TabStop = false;
            this.btnBottomRight.Text = "C";
            this.btnBottomRight.UseVisualStyleBackColor = false;
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic);
            this.btnTopLeft.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTopLeft.Location = new System.Drawing.Point(131, 173);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(306, 153);
            this.btnTopLeft.TabIndex = 7;
            this.btnTopLeft.TabStop = false;
            this.btnTopLeft.Text = "Q";
            this.btnTopLeft.UseVisualStyleBackColor = false;
            // 
            // btnTopRight
            // 
            this.btnTopRight.BackColor = System.Drawing.Color.Transparent;
            this.btnTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic);
            this.btnTopRight.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTopRight.Location = new System.Drawing.Point(613, 173);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(306, 153);
            this.btnTopRight.TabIndex = 9;
            this.btnTopRight.TabStop = false;
            this.btnTopRight.Text = "E";
            this.btnTopRight.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLeft.Location = new System.Drawing.Point(165, 325);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(203, 134);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "A";
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnForward.Location = new System.Drawing.Point(436, 192);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(178, 121);
            this.btnForward.TabIndex = 8;
            this.btnForward.TabStop = false;
            this.btnForward.Text = "W";
            this.btnForward.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRight.Location = new System.Drawing.Point(677, 325);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(210, 127);
            this.btnRight.TabIndex = 11;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "D";
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.Transparent;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackward.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBackward.Location = new System.Drawing.Point(436, 464);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(178, 124);
            this.btnBackward.TabIndex = 13;
            this.btnBackward.TabStop = false;
            this.btnBackward.Text = "S";
            this.btnBackward.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(1926, 130);
            this.trackBarSpeed.Maximum = 2;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSpeed.Size = new System.Drawing.Size(114, 623);
            this.trackBarSpeed.TabIndex = 15;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trackBarTurningDegree
            // 
            this.trackBarTurningDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.trackBarTurningDegree.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.trackBarTurningDegree.LargeChange = 1;
            this.trackBarTurningDegree.Location = new System.Drawing.Point(2065, 130);
            this.trackBarTurningDegree.Maximum = 1;
            this.trackBarTurningDegree.Name = "trackBarTurningDegree";
            this.trackBarTurningDegree.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTurningDegree.RightToLeftLayout = true;
            this.trackBarTurningDegree.Size = new System.Drawing.Size(114, 326);
            this.trackBarTurningDegree.TabIndex = 16;
            this.trackBarTurningDegree.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTurningDegree.Value = 1;
            this.trackBarTurningDegree.Scroll += new System.EventHandler(this.trackBarTurningDegree_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1946, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(2059, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "TD";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.ForeColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Location = new System.Drawing.Point(1946, 786);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(0, 32);
            this.lblSpeed.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(2118, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "slow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(2118, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "fast";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btnDisconnect;
            this.ClientSize = new System.Drawing.Size(2239, 949);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarTurningDegree);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R2LAB Competition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurningDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPortSelect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnIR;
        private System.Windows.Forms.Button btnUltraSonic;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar trackBarTurningDegree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

