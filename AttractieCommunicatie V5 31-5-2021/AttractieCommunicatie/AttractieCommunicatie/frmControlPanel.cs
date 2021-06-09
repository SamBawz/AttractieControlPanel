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
using System.Configuration;


namespace AttractieCommunicatie
{
    public partial class frmControlPanel : Form
    {
        bool recieveSignals = false;

        [Obsolete]
        public frmControlPanel()
        {
            InitializeComponent();
        }

        #region Functies
        private void updateGUI()
        {
            //Enable/disable controls
            foreach (Control control in this.Controls)
            {
                //Uitzonderingen
                if (control == btnPower || control == btnTerug || control == cbPorts || control == lblUser) { }
                else if (control.Enabled != Arduino.power)
                {
                    control.Enabled = Arduino.power;
                }
            }

            //Update element values
            if (!Arduino.power)
            {
                cbPorts.Enabled = true;
                btnPower.BackColor = Color.Red;

                pbPower.Value = 0;
                lblPower.Text = "Power: 0";

                trkbrSpeed.Value = 0;
                lblSpeed.Text = "Snelheid: 0";

                btnReverse.BackColor = Color.Gray;

                pbBattery.Value = 0;
                lblBattery.Text = "Batterij: 0";

                Sound.aStopAll();

            }
            else if (Arduino.power)
            {
                cbPorts.Enabled = false;
                btnPower.BackColor = Color.Green;

                //Update de GUI
                lblPower.Text = "Power: " + Arduino.ldrValue.ToString();
                pbPower.Value = Arduino.ldrValue;

                trkbrSpeed.Value = Arduino.speed;
                lblSpeed.Text = "Snelheid: " + Arduino.speed;

                if (Arduino.reverse)
                {
                    btnReverse.BackColor = Color.Green;
                }
                else
                {
                    btnReverse.BackColor = Color.Red;
                }

                lblBattery.Text = "Batterij: " + Convert.ToInt32(Arduino.battery).ToString();
                pbBattery.Value = Convert.ToInt32(Arduino.battery);
            }
        }

        private void testConnection()
        {
            if(!Database.testConnection())
            {
                Arduino.power = false;
                this.Close();
            }
        }
        #endregion

        #region Events
        private void frmControlPanel_Load(object sender, EventArgs e)
        {
            lblUser.Text = Account.getCurrentUser();
            Database.closeConnection();

            //Laad alle open poorten in een combobox
            cbPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            //Configureer de main poort instellingen
            serialPortArduino.BaudRate = (9600);
            serialPortArduino.ReadTimeout = (2000);
            serialPortArduino.WriteTimeout = (2000);

            Config.MainPort = serialPortArduino;
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update de main poort zodra de gebruiker een andere poort selecteerd
            serialPortArduino.PortName = cbPorts.Text;
            Config.MainPort = serialPortArduino;
        }

        //Het verwerken van de signalen die de applicatie ontvangt van de arduino
        private void serialPortArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!Communication.recieveSignal() && recieveSignals)
            {
                Arduino.power = false;
                MessageBox.Show("Er is iets mis met de verbinding.");
            }
        }

        private void sendSignals()
        {
            //Vraag de arduino om waardes terug te sturen (zoals de ldr waarde)
            if (!Communication.sendSignal("send"))
            {
                Arduino.power = false;
                MessageBox.Show("De verbinding is verbroken.");
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            testConnection();
            updateGUI();
            if (Arduino.power)
            {
                recieveSignals = true;
                sendSignals();
                Arduino.calculateBatteryLevel();
            }
            else
            {
                recieveSignals = false;
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Arduino.togglePower();
        }
    
        private void trkbrSpeed_Scroll(object sender, EventArgs e)
        {
            Arduino.speed = trkbrSpeed.Value;
            
            if (trkbrSpeed.Value == 2)
            {
                Sound.aSnel();
            }
            else if (trkbrSpeed.Value == 3)
            {
                Sound.aSneller();
            }
            else if (trkbrSpeed.Value == 4)
            {
                Sound.aTurbo();
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Sound.aDraaien();

            if (Arduino.reverseAttraction())
            {
                btnReverse.BackColor = Color.Green;
            }
            else
            {
                btnReverse.BackColor = Color.Red;
            }
        }
        #endregion

        #region Audio
        private void btnStart_Click(object sender, EventArgs e)
        {
            Sound.aStart();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Sound.aStopAll();
        }
        #endregion

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Arduino.power = false;
            this.Close();
        }
    }
}
