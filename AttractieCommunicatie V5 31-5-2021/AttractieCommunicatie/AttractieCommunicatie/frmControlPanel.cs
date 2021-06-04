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
        bool controlPanelStatus = false;

        [Obsolete]
        public frmControlPanel()
        {
            InitializeComponent();
        }

        #region Functies
        //Reset de control panel naar hoe het uitzag voordat er een poort opengezet werd
        public void closeControlPanel()
        {
            if (controlPanelStatus)
            {
                controlPanelStatus = false;
                toggleTimers(false);
                toggleEnabledControls(false);
                btnPower.BackColor = Color.Red;

                pbPower.Value = 0;
                lblPower.Text = "Power: 0";

                trkbrSpeed.Value = 0;
                lblSpeed.Text = "Snelheid: 0";

                btnReverse.BackColor = Color.Gray;

                Sound.aStopAll();
            }
        }

        //Hoe de control panel er uit hoort te zien na een poort opengezet wordt
        public void openControlPanel()
        {
            if (!controlPanelStatus)
            {
                controlPanelStatus = true;
                toggleTimers(true);
                toggleEnabledControls(true);
                btnPower.BackColor = Color.Green;

                if (Arduino.battery < 1)
                {
                    Arduino.battery = 10m;
                }
            }    
        }

        /// <summary>
        /// Enabled of disabled alle controls op de control panel
        /// </summary>
        /// <param name="enabled">true = enable, false = disable</param>
        private void toggleEnabledControls(bool enabled)
        {
            foreach (Control control in this.Controls)
            {
                //Uitzonderingen
                if (control.Name == btnPower.Name || control.Name == btnTerug.Name || control.Name == cbPorts.Name) { }
                else if (control.Enabled != enabled)
                {
                    control.Enabled = enabled;
                }
            }

            //cbPorts wilt het tegenovergestelde van de parameter aanhouden
            if (Arduino.power && !enabled)
            {
                cbPorts.Enabled = false;
            }
            else if (!Arduino.power && enabled)
            {
                cbPorts.Enabled = true;
            }        
        }

        /// <summary>
        /// Zet de timers waarmee signalen ontvangen en verstuurd worden aan of uit
        /// </summary> 
        /// <param name="enable">true = aan, false = uit</param>
        private void toggleTimers(bool enable)
        {
            tmrSend.Enabled = enable;
            tmrBattery.Enabled = enable;
        }
        #endregion

        #region Events
        private void frmControlPanel_Load(object sender, EventArgs e)
        {
            //Laad alle open poorten in een combobox
            cbPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            //Configureer de main poort instellingen
            serialPortArduino.BaudRate = (9600);
            serialPortArduino.ReadTimeout = (2000);
            serialPortArduino.WriteTimeout = (2000);
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
            if (!Communication.recieveSignal())
            {
                MessageBox.Show("Er is iets mis met de verbinding.");
                Arduino.togglePower();
            }
        }

        //Het sturen van signalen naar de arduino
        private void tmrSend_Tick(object sender, EventArgs e)
        {
            //Vraag de arduino om waardes terug te sturen (zoals de ldr waarde)
            Communication.sendSignal("send");
        }

        private void tmrUpdateGUI_Tick(object sender, EventArgs e)
        {
            if (!Arduino.power)
            {
                closeControlPanel();
            }
            else if (Arduino.power)
            {
                openControlPanel();

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

                lblBattery.Text = Convert.ToInt32(Arduino.battery).ToString();
                pbBattery.Value = Convert.ToInt32(Arduino.battery);
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
            this.Close();
        }

        #region Battery 
        private void tmrBattery_Tick(object sender, EventArgs e)
        {
            Arduino.calculatePower();
        }
        #endregion

    }
}
