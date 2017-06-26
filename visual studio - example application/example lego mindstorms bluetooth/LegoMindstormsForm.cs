using EV3MessengerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Example_Lego_Mindstorms_Bluetooth
{
    public partial class LegoMindstormsForm : Form
    {
        public EV3Messenger messenger;

        public LegoMindstormsForm()
        {
            InitializeComponent();
            // Init application
            messenger = new EV3Messenger();
                       fillSerialPortSelectionBoxWithAvailablePorts();
            updateFormGUI();
        }


        // status variables
        public string[] status = new string[4];
        public string moveState = "idle";
        public string loadState = "unloaded";
        public string proxyCounter = "0";
        public string positionNumber = "1";
        public string outputMessage = "";

        //method

            public void SendInstruction(string order, bool buttonreset)
        {
           // Send a message to the Brick with title: MESSAGE and the message
            if (messenger.SendMessage("MESSAGE", order))
            {
                //update output box
                EV3Message message = messenger.ReadMessage();
                if (message != null)
                {
                    status = message.ValueAsText.Split();
                    moveState = status[0];
                    loadState = status[1];
                    proxyCounter = status[2];
                    positionNumber = status[3];

                    switch (positionNumber)
                    {
                        default:
                            positionNumber = "Runway 1";
                            break;
                        case "2":
                            positionNumber = "Pick-up Zone";
                            break;
                        case "3":
                            positionNumber = "Runway 2";
                            break;
                        case "4":
                            positionNumber = "Drop-off Zone";
                            break;
                        case "5":
                            positionNumber = "Runway 3";
                            break;
                    }


                    // output list clear and update
                    outputlistBox.Items.Clear();
                    outputMessage = moveState + loadState + proxyCounter + positionNumber;
                    outputlistBox.Items.Add(outputMessage);
                    outputlistBox.TopIndex = outputlistBox.Items.Count - 1;

                    //button disabling & enabling to default state
                    if (buttonreset)
                    {
                        btnStart.Enabled = true;
                        btnPause.Enabled = false;
                        btnStop.Enabled = false;
                    }
                   


                }
            }
        }

        #region Connection form
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Check if a port has been selected
            if (portListBox.SelectedIndex > -1)
            {
                // Get the selected port from the ListBox
                string port = portListBox.SelectedItem.ToString().ToUpper();
                // Try to connect with the Brick via the selected port
                if (messenger.Connect(port))
                {
                    updateFormGUI();
                }
                else
                {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Make sure your robot is connected to that serial port and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a port for the bluetooth connection");
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            // Disconnect from the Brick
            messenger.Disconnect();

            updateFormGUI();
        }

        private void fillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            portListBox.Items.Clear();
            foreach (String port in ports)
            {
                portListBox.Items.Add(port);
            }
        }

        #endregion

        #region Input & output form

        //private void inputButton_Click(object sender, EventArgs e)
        //{
        //    string txtMsg = inputTextBox.Text;
        //    // Make sure a message has been typed
        //    if (!String.IsNullOrWhiteSpace(txtMsg))
        //    {
        //        // Send a message to the Brick with title: MESSAGE and the message
        //        if (messenger.SendMessage("MESSAGE", txtMsg))
        //        {
        //            inputTextBox.Text = "";
        //            MessageBox.Show("The message has been send to the Brick");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Unable to send the message to the Brick. Please try again.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please type a message in the above textbox for the Brick");
        //    }
        //}

        //private void outputButton_Click(object sender, EventArgs e)
        //{
        //    // Try to get a message
        //    EV3Message message = messenger.ReadMessage();
        //    // Check if there is a message received from the Brick
        //    if (message != null)
        //    {
 


        //        outputlistBox.Items.Add("Message: " + message.ValueAsText);
        //        // Auto scroll the listbox
        //        outputlistBox.TopIndex = outputlistBox.Items.Count - 1;
        //    }
        //    else
        //    {
        //        MessageBox.Show("No message recieved from the Brick");
        //    }
        //}

        #endregion

        #region GUI

        private void updateFormGUI()
        {
            if (messenger.IsConnected)
            {
                refreshButton.Enabled = false;
                connectButton.Enabled = false;

                outputGroupBox.Enabled = true;
                disconnectButton.Enabled = true;

                outputlistBox.Items.Clear();
            }
            else
            {
                refreshButton.Enabled = true;
                connectButton.Enabled = true;

                outputGroupBox.Enabled = false;
                disconnectButton.Enabled = false;
            }
        }

        #endregion

     
        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            SendInstruction("forward",true);
           
        }

        private void btnForward_MouseUp(object sender, MouseEventArgs e)
        {
            SendInstruction("stop", true);
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            SendInstruction("left", true);
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            SendInstruction("stop", true);
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            SendInstruction("right", true);
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            SendInstruction("stop", true);
        }

        private void btnReverse_MouseDown(object sender, MouseEventArgs e)
        {
            SendInstruction("reverse", true);
        }

        private void btnReverse_MouseUp(object sender, MouseEventArgs e)
        {
            SendInstruction("stop", true);
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            SendInstruction("load", false);
            btnPickUp.Enabled = false;
            btnDropOff.Enabled = true;
            btnDropOff.Focus();
            

        }

        private void btnDropOff_Click(object sender, EventArgs e)
        {

            SendInstruction("unload", false);
            btnPickUp.Enabled = true;
            btnDropOff.Enabled = false;
            btnPickUp.Focus();
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SendInstruction("start", false);
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnPause.Focus();

            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {


            SendInstruction("pause", true);
            btnPause.Enabled = false;
            btnStop.Enabled = true;

            btnStart.Text = "Resume";
            btnStart.Enabled = true;
            btnStart.Focus();

            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            SendInstruction("stop", false);
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            btnStart.Text = "Start";
            btnStart.Enabled = true;
            btnStart.Focus();

           
        }
    }
}
