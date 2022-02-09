using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IntelligentControllableRobot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] portSelect;
        public int[] baudRates = new int[11];
        public bool baudRateCheck, portCheck, serialPort1Check, boolSwitch, boolTimer2, boolTurningDegree;
        public int portSelectCounter = 0, baudRateCounter = 0, j_temp;
        public string str = "P", str_sends_once = "P";

        public void check_trackBarSpeed()
        {
            if (trackBarSpeed.Value == 0)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Write(",");
            }

            if (trackBarSpeed.Value == 1)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Write(".");
            }

            if (trackBarSpeed.Value == 2)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Write("/");
            }
        }

        public void check_trackBarTurningDegree()
        {
            if (trackBarTurningDegree.Value == 0)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Write("]");
            }

            if (trackBarTurningDegree.Value == 1)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Write("[");
            }
        }

        public void DisablingSensors()
        {
            if (boolTimer2)
            {
                timer2.Stop();
                boolTimer2 = false;
                btnUltraSonic.BackColor = Color.Transparent;
                btnIR.BackColor = Color.Transparent;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string baudRate in cmbBaudRate.Items)
                baudRates[baudRateCounter++] = Convert.ToInt32(baudRate);

            foreach (string port in SerialPort.GetPortNames())
                cmbPortSelect.Items.Add(port);

            portSelect = new string[cmbPortSelect.Items.Count];

            foreach (string port in SerialPort.GetPortNames())
                portSelect[portSelectCounter++] = port;

            lblSpeed.Text = "200";

            portSelectCounter = 0;
        }

        private void cmbPortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btnConnect.Enabled)
                btnDisconnect_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbPortSelect.Items.Clear();
            cmbPortSelect.Text = "Port Select";

            foreach (string port in SerialPort.GetPortNames())
                cmbPortSelect.Items.Add(port);

            portSelect = new string[cmbPortSelect.Items.Count];

            foreach (string port in SerialPort.GetPortNames())
                portSelect[portSelectCounter++] = port;

            portSelectCounter = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = 0; i < baudRates.Length || j < cmbPortSelect.Items.Count; i++, j++)
            {
                if (i >= baudRates.Length && portCheck)
                    break;
                else if (i >= baudRates.Length)
                    i = baudRates.Length - 1;

                if (j >= cmbPortSelect.Items.Count)
                    j = cmbPortSelect.Items.Count - 1;

                if (portCheck)
                    j = j_temp;

                try
                {
                    if (cmbPortSelect.Text == portSelect[j])
                    {
                        portCheck = true;
                        j_temp = j;

                        if (cmbBaudRate.Text == baudRates[i].ToString())
                        {
                            baudRateCheck = true;

                            if (!serialPort1.IsOpen)
                            {
                                serialPort1.PortName = cmbPortSelect.Text;
                                serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.Text);

                                try
                                {
                                    serialPort1.Open();
                                    timer1.Start();
                                }
                                catch
                                {
                                    MessageBox.Show("Port's Busy.");
                                    serialPort1Check = true;
                                }

                                if (!serialPort1Check)
                                {
                                    btnRefresh.Enabled = false;
                                    btnDisconnect.Enabled = true;
                                    btnConnect.Enabled = false;
                                    MessageBox.Show("Connected");
                                }

                                btnOff.Focus();
                                portCheck = false;
                                serialPort1Check = false;
                            }
                            else
                                MessageBox.Show("Check Your Setting Please.");

                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Can Not Connect.");
                    baudRateCheck = true;
                    break;
                }
            }

            if (!baudRateCheck)
            {
                baudRateCheck = false;
                MessageBox.Show("Check Your Setting Please.");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = true;
            btnConnect.Enabled = true;
            baudRateCheck = false;
            MessageBox.Show("Disconnected");

            serialPort1.Close();
        }

        private void cmbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btnConnect.Enabled)
                btnDisconnect_Click(sender, e);
        }

        private void btnOff_KeyUp(object sender, KeyEventArgs e)
        {
            str = "P";
            btnForward.ForeColor = Color.DeepSkyBlue;
            btnForward.BackColor = Color.Transparent;
            btnBackward.ForeColor = Color.DeepSkyBlue;
            btnBackward.BackColor = Color.Transparent;
            btnRight.ForeColor = Color.DeepSkyBlue;
            btnRight.BackColor = Color.Transparent;
            btnLeft.ForeColor = Color.DeepSkyBlue;
            btnLeft.BackColor = Color.Transparent;
            btnTopLeft.ForeColor = Color.DeepSkyBlue;
            btnTopLeft.BackColor = Color.Transparent;
            btnTopRight.ForeColor = Color.DeepSkyBlue;
            btnTopRight.BackColor = Color.Transparent;
            btnBottomLeft.ForeColor = Color.DeepSkyBlue;
            btnBottomLeft.BackColor = Color.Transparent;
            btnBottomRight.ForeColor = Color.DeepSkyBlue;
            btnBottomRight.BackColor = Color.Transparent;
            btnOff.ForeColor = Color.DeepSkyBlue;
            btnOff.BackColor = Color.Transparent;
        }

        private void btnOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'P' || e.KeyChar == 'p')
            {
                if (!boolTimer2)
                {
                    str_sends_once = "P";
                    timer2.Start();
                    boolTimer2 = true;
                }
                else
                {
                    timer2.Stop();
                    boolTimer2 = false;
                }

                btnOff.ForeColor = Color.Transparent;
                btnOff.BackColor = Color.Teal;
                btnOff.Focus();
            }

            if (e.KeyChar == 'U' || e.KeyChar == 'u')
            {
                if (!boolTimer2)
                {
                    str_sends_once = "U";
                    timer2.Start();
                    boolTimer2 = true;
                    btnUltraSonic.BackColor = Color.White;
                }
                else
                {
                    timer2.Stop();
                    boolTimer2 = false;
                    btnUltraSonic.BackColor = Color.Transparent;
                }
                btnIR.BackColor = Color.Transparent;
            }

            if (e.KeyChar == 'I' || e.KeyChar == 'i')
            {
                if (!boolTimer2)
                {
                    str_sends_once = "I";
                    timer2.Start();
                    boolTimer2 = true;
                    btnIR.BackColor = Color.White;
                }
                else
                {
                    timer2.Stop();
                    boolTimer2 = false;
                    btnIR.BackColor = Color.Transparent;
                }
                btnUltraSonic.BackColor = Color.Transparent;
            }
        }

        private void btnOff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                str = "W";
                btnForward.ForeColor = Color.Transparent;
                btnForward.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.S)
            {
                str = "S";
                btnBackward.ForeColor = Color.Transparent;
                btnBackward.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.A)
            {
                str = "A";
                btnLeft.ForeColor = Color.Transparent;
                btnLeft.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.D)
            {
                str = "D";
                btnRight.ForeColor = Color.Transparent;
                btnRight.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.Q)
            {
                str = "Q";
                btnTopLeft.ForeColor = Color.Transparent;
                btnTopLeft.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.E)
            {
                str = "E";
                btnTopRight.ForeColor = Color.Transparent;
                btnTopRight.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.Z)
            {
                str = "Z";
                btnBottomLeft.ForeColor = Color.Transparent;
                btnBottomLeft.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.C)
            {
                str = "C";
                btnBottomRight.ForeColor = Color.Transparent;
                btnBottomRight.BackColor = Color.Teal;
                btnOff.Focus();

                DisablingSensors();
            }

            if (e.KeyCode == Keys.NumPad3)
            {
                trackBarSpeed.Value = 2;
                check_trackBarSpeed();
                lblSpeed.Text = "255";
            }

            if (e.KeyCode == Keys.NumPad2)
            {
                trackBarSpeed.Value = 1;
                check_trackBarSpeed();
                lblSpeed.Text = "200";
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                trackBarSpeed.Value = 0;
                check_trackBarSpeed();
                lblSpeed.Text = "145";
            }

            if (e.KeyCode == Keys.Space)
            {
                if (!boolTurningDegree)
                {
                    trackBarTurningDegree.Value = 0;
                    trackBarTurningDegree.BackColor = Color.DarkSlateGray;
                    boolTurningDegree = true;
                }
                else
                {
                    trackBarTurningDegree.Value = 1;
                    trackBarTurningDegree.BackColor = Color.FromArgb(121, 0, 3);
                    boolTurningDegree = false;
                }

                check_trackBarTurningDegree();
            }
        }
        
        private void btnUltraSonic_Click(object sender, EventArgs e)
        {
            if (!boolTimer2)
            {
                str_sends_once = "U";
                timer2.Start();
                boolTimer2 = true;
                btnUltraSonic.BackColor = Color.White;
            }
            else
            {
                timer2.Stop();
                boolTimer2 = false;
                btnUltraSonic.BackColor = Color.Transparent;
            }
            btnIR.BackColor = Color.Transparent;
            btnOff.Focus();
        }

        private void btnIR_Click(object sender, EventArgs e)
        {
            if (!boolTimer2)
            {
                str_sends_once = "I";
                timer2.Start();
                boolTimer2 = true;
                btnIR.BackColor = Color.White;
            }
            else
            {
                timer2.Stop();
                boolTimer2 = false;
                btnIR.BackColor = Color.Transparent;
            }
            btnUltraSonic.BackColor = Color.Transparent;
            btnOff.Focus();
        }

        private void trackBarTurningDegree_Scroll(object sender, EventArgs e)
        {
            btnOff.Focus();
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            btnOff.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Write(str);
            }
            catch { MessageBox.Show("Port's Not Accessible."); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                serialPort1.Write(str_sends_once);
            }
            catch { MessageBox.Show("Port's Not Accessible."); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
