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

namespace PlantCareSystem_Monitor
{
    public partial class Form1 : Form
    {
        //Control variables for different systems
        Boolean isFanWork = false;
        Boolean isLightWork = false;
        Boolean isMovementWork = false;
        Boolean isMoistureWork = false;

        //Data buffer
        String receivedData = null;

        public Form1()
        {
            InitializeComponent();

            //Default settings
            btnDisconnect.Enabled = false;

            //Slider values
            lblFanSpeed.Text = sliderFanSpeed.Value.ToString();
            lblTarget.Text = sliderTargetTemperature.Value.ToString(); //Temperature
            lblLightTarget.Text = sliderLightTarget.Value.ToString();
            lblMoistureTarget.Text = sliderMoistureTarget.Value.ToString();

            //Combobox selected indexes
            cmbLightColors.SelectedIndex = 0;
            cmbMoisture.SelectedIndex = 0;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Serialport Combobox Initializing
            string[] serialPorts = SerialPort.GetPortNames();

            foreach (string serialPort in serialPorts)
            {
                cmbSerialPorts.Items.Add(serialPort);
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = cmbSerialPorts.Text;
                    serialPort.BaudRate = 9600;
                    serialPort.Open();
                    btnDisconnect.Enabled = true;
                    btnConnect.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Connect Serial Port!", "Error!");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Disconnect Serial Port!", "Error!");
            }

        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    receivedData = serialPort.ReadLine();
                    this.BeginInvoke(new EventHandler(readData_event));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Serial Port Disconnected!", "Error!");
                    serialPort.Close();
                }
            }
        }


        private void readData_event(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    String[] commandData = receivedData.Replace("\n", "").Replace("\r", "").Split('<');
                    String command = commandData[0];
                    String value = commandData[1];

                    if (command == "isik")
                    {
                        txtLight.Text = value;
                        txtLight_TextChanged(sender, e);
                    }
                    else if (command == "nem")
                    {
                        txtMoisture.Text = value;
                        txtMoisture_TextChanged(sender, e);
                    }
                    else if (command == "hareket")
                    {
                        txtMovement.Text = value;
                        txtMovement_TextChanged(sender, e);
                    }
                    else if (command == "sicaklik")
                    {
                        txtTemperature.Text = value;
                        txtTemperature_TextChanged(sender, e);
                    }


                }
                catch (Exception ex)
                {
                    //Invalid command
                    //Skip this command
                }
            }
        }

        private void sliderTargetTemperature_Scroll(object sender, EventArgs e)
        {
            lblTarget.Text = sliderTargetTemperature.Value.ToString();
        }

        private void sliderFanSpeed_Scroll(object sender, EventArgs e)
        {
            lblFanSpeed.Text = sliderFanSpeed.Value.ToString();
        }

        private void txtTemperature_TextChanged(object sender, EventArgs e)
        {
            if (isFanWork == false)
            {
                if (sliderTargetTemperature.Value < Convert.ToInt32(txtTemperature.Text))
                {

                    DialogResult dialogResult = new DialogResult();
                    isFanWork = true;
                    dialogResult = MessageBox.Show("Do you want to run the fan at the desired speed?", "The temperature has reached the target.", MessageBoxButtons.YesNo);


                    if (dialogResult == DialogResult.Yes)
                    {
                        serialPort.Write("fanHiz>" + sliderFanSpeed.Value);
                        sliderFanSpeed.Enabled = false;
                        sliderTargetTemperature.Enabled = false;
                        isFanWork = true;
                        btnFanStop.Visible = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        isFanWork = false;
                        btnFanStop.Visible = false;
                        sliderTargetTemperature.Value = sliderTargetTemperature.Maximum;
                        lblTarget.Text = sliderTargetTemperature.Maximum.ToString();
                    }
                }
            }

        }

        private void btnFanStop_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("fanHiz>0");
                sliderTargetTemperature.Value = sliderTargetTemperature.Maximum;
                isFanWork = false;
                sliderFanSpeed.Enabled = true;
                sliderTargetTemperature.Enabled = true;
                btnFanStop.Visible = false;
            }
        }

        private void txtLight_TextChanged(object sender, EventArgs e)
        {
            if (isLightWork == false)
            {
                if (Convert.ToInt32(txtLight.Text) < sliderLightTarget.Value)
                {

                    DialogResult dialogResult = new DialogResult();
                    isLightWork = true;
                    dialogResult = MessageBox.Show("Would you like to turn on the lights with current settings? ", "Amount of light under the target!", MessageBoxButtons.YesNo);


                    if (dialogResult == DialogResult.Yes)
                    {
                        serialPort.Write("ledMod>" + (cmbLightColors.SelectedIndex + 1));
                        lightTimer.Interval = Convert.ToInt32(txtLightTime.Text) * 1000;
                        lightTimer.Start();
                        txtLightTime.Enabled = false;
                        sliderLightTarget.Enabled = false;
                        cmbLightColors.Enabled = false;
                        isLightWork = true;

                        progressLight.Maximum = Convert.ToInt32(txtLightTime.Text);
                        progressLight.Value = 0;

                        progressTimerLight.Interval = 1000;
                        progressLight.Visible = true;
                        progressTimerLight.Start();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        isLightWork = false;
                        sliderLightTarget.Value = sliderLightTarget.Minimum;
                        lblLightTarget.Text = sliderLightTarget.Minimum.ToString();

                    }
                }
            }
        }

        private void sliderLightTarget_Scroll(object sender, EventArgs e)
        {
            lblLightTarget.Text = sliderLightTarget.Value.ToString();
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("ledMod>0");
                lightTimer.Stop();
                sliderLightTarget.Enabled = true;
                isLightWork = false;
                txtLightTime.Enabled = true;
                cmbLightColors.Enabled = true;
                sliderLightTarget.Value = sliderLightTarget.Minimum;
                lblLightTarget.Text = sliderLightTarget.Minimum.ToString();
                progressLight.Visible = false;
                progressTimerLight.Stop();
                progressLight.Value = 0;
            }

        }

        private void txtMovement_TextChanged(object sender, EventArgs e)
        {
            if (isMovementWork == false && radioBtnOn.Checked==true && radioBtnOff.Checked==false)
            {
                if (0 < Convert.ToInt32(txtMovement.Text))
                {

                    DialogResult dialogResult = new DialogResult();
                    isMovementWork = true;
                    dialogResult = MessageBox.Show("Would you like to play a sound with current settings? ", "Motion Detected!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        serialPort.Write("buzzerMod>1");
                        movementTimer.Interval = Convert.ToInt32(txtBuzzerTime.Text) * 1000;
                        movementTimer.Start();

                        progressMotion.Maximum = Convert.ToInt32(txtBuzzerTime.Text);
                        progressMotion.Value = 0;

                        progressTimerMotion.Interval = 1000;
                        progressMotion.Visible = true;
                        progressTimerMotion.Start();

                        txtBuzzerTime.Enabled = false;
                        isMovementWork = true;

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        isMovementWork = false;


                    }
                }
            }
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("buzzerMod>0");
                movementTimer.Stop();
                isMovementWork = false;
                txtBuzzerTime.Enabled = true;
                progressTimerMotion.Stop();
                progressMotion.Visible = false;
                progressMotion.Value = 0;
            }
           
            
        }


        private void radioBtnOff_Click(object sender, EventArgs e)
        {
            //txtBuzzerTime.Enabled = false;

        }

        private void radioBtnOn_Click(object sender, EventArgs e)
        {
            //txtBuzzerTime.Enabled = true;
        }

        private void txtMoisture_TextChanged(object sender, EventArgs e)
        {
            if (isMoistureWork == false)
            {
                if (Convert.ToInt32(txtMoisture.Text) < sliderMoistureTarget.Value)
                {

                    DialogResult dialogResult = new DialogResult();
                    isMoistureWork = true;
                    dialogResult = MessageBox.Show("Would you like to run water pump with current settings?", "Moisture under below target!", MessageBoxButtons.YesNo);


                    if (dialogResult == DialogResult.Yes)
                    {
                        serialPort.Write("suMotorHiz>60");
                        moistureTimer.Interval = (cmbMoisture.SelectedIndex + 1)*3000;
                        moistureTimer.Start();
                        txtMoisture.Enabled = false;
                        sliderMoistureTarget.Enabled = false;
                        cmbMoisture.Enabled = false;
                        isMoistureWork = true;

                        progressMoisture.Maximum = (cmbMoisture.SelectedIndex + 1) * 3;
                        progressMoisture.Value = 0;

                        progressTimerMoisture.Interval = 1000;
                        progressMoisture.Visible = true;
                        progressTimerMoisture.Start();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        isMoistureWork = false;
                        sliderMoistureTarget.Value = sliderMoistureTarget.Minimum;
                        lblMoistureTarget.Text = sliderMoistureTarget.Minimum.ToString();
                        txtMoisture.Enabled = true;
                        sliderMoistureTarget.Enabled = true;
                        cmbMoisture.Enabled = true;

                    }
                }
            }
        }

        private void moistureTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("suMotorHiz>0");
                moistureTimer.Stop();
                isMoistureWork = false;
                txtMoisture.Enabled = true;
                sliderMoistureTarget.Enabled = true;
                cmbMoisture.Enabled = true;
                sliderMoistureTarget.Value = sliderMoistureTarget.Minimum;
                lblMoistureTarget.Text = sliderMoistureTarget.Minimum.ToString();
                progressMoisture.Visible = false;
                progressTimerMoisture.Stop();
                progressMoisture.Value = 0;
            }
        }

        private void sliderMoistureTarget_Scroll(object sender, EventArgs e)
        {
            lblMoistureTarget.Text = sliderMoistureTarget.Value.ToString();
        }

        private void txtLightTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtLightTime.Text);
            }
            catch (Exception Ex)
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Please enter a valid duration!","Error!", MessageBoxButtons.OK);
                isLightWork = true;
                if (dialogResult == DialogResult.OK)
                {
                    txtLightTime.Text = "5";
                    isLightWork = false;
                }         
            }
        }

        private void txtBuzzerTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtBuzzerTime.Text);
            }
            catch (Exception Ex)
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Please enter a valid duration!", "Error!", MessageBoxButtons.OK);
                isMovementWork = true;
                if (dialogResult == DialogResult.OK)
                {
                    txtBuzzerTime.Text = "5";
                    isMovementWork = false;
                }
            }
        }

        private void progressTimerMotion_Tick(object sender, EventArgs e)
        {
            if (progressMotion.Value < progressMotion.Maximum)
            {
                progressMotion.Value += 1;
            }
           
        }

        private void progressTimerMoisture_Tick(object sender, EventArgs e)
        {
            if (progressMoisture.Value < progressMoisture.Maximum)
            {
                progressMoisture.Value += 1;
            }
        }

        private void progressTimerLight_Tick(object sender, EventArgs e)
        {
            if (progressLight.Value < progressLight.Maximum)
            {
                progressLight.Value += 1;
            }
        }
    }
}
