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
        List<Port> ports = new List<Port>();
        List<Config> configuration = new List<Config>();
        System.Media.SoundPlayer snel = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Snel"]);
        System.Media.SoundPlayer start = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Start"]);
        System.Media.SoundPlayer sneller = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Sneller"]);
        System.Media.SoundPlayer turbo = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Turbo"]);
        System.Media.SoundPlayer draaien = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Draaien"]);
        string arduinoSignal = "";
        private decimal batterijPercentage;

        [Obsolete]
        public frmControlPanel()
        {
            InitializeComponent();
        }

        #region Functies
        //Reset de control panel naar hoe het uitzag voordat er een poort opengezet werd
        public void closeControlPanel()
        {
            toggleTimers(false);
            toggleEnabledControls(false);
            trkbrSpeed.Value = 2;
            pbPower.Value = 0;
            lblSpeed.Text = "Snelheid: 2";
            lblPower.Text = "Power: ";
            btnPower.BackColor = Color.Red;
            btnReverse.BackColor = Color.Gray;
        }

        //Hoe de control panel er uit hoort te zien na een poort opengezet wordt
        public void openControlPanel()
        {
            toggleTimers(true);
            toggleEnabledControls(true);
            trkbrSpeed.Value = findSelectedPortConfig().speed;
            lblSpeed.Text = "Snelheid: " + findSelectedPortConfig().speed;
            btnPower.BackColor = Color.Green;
            if (findSelectedPortConfig().reverse)
            {
                btnReverse.BackColor = Color.Green;
            }
            else
            {
                btnReverse.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Stuurt een signaal naar de gekozen poort
        /// </summary>
        /// <param name="signal">Het bericht dat verstuurd dient te worden</param>
        private void sendSignal(string signal)
        {
            //sendCommand
            try
            {
                serialPortArduino.Write(signal);
            }
            catch (Exception ex)
            {
                closeControlPanel();
                MessageBox.Show(ex.Message);
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
                control.Enabled = enabled;
            }

            //uitzonderingen
            btnPower.Enabled = true;
            if (enabled)
            {
                cbPorts.Enabled = false;
            }
            else
            {
                cbPorts.Enabled = true;
            }        
        }

        //Stuurt de configuratie klasse van de gebruikte poort terug
        private Port findSelectedPortConfig()
        {
            foreach (Port port in ports)
            {
                if (port.portName == serialPortArduino.PortName)
                {
                    return port;
                }
            }
            return null;
        }

        /// <summary>
        /// Zet de timers waarmee signalen ontvangen en verstuurd worden aan of uit
        /// </summary> 
        /// <param name="enable">true = aan, false = uit</param>
        private void toggleTimers(bool enable)
        {
            tmrSend.Enabled = enable;
            tmrRecieve.Enabled = enable;
        }
        #endregion

        #region Events
        private void frmControlPanel_Load(object sender, EventArgs e)
        {
            //Laad alle open poorten in een combobox
            cbPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            //Maak voor elke poort een configuratie klasse waarin de instellingen opgeslagen worden
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
            {
                Port _port = new Port(port, 2, false, 0);
                ports.Add(_port);
            }

            //Configureer de main poort instellingen
            serialPortArduino.BaudRate = (9600);
            serialPortArduino.ReadTimeout = (2000);
            serialPortArduino.WriteTimeout = (2000);
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortArduino.PortName = cbPorts.Text;
        }

        private void serialPortArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Command received
            arduinoSignal = serialPortArduino.ReadLine();
        }

        //Het sturen van signalen naar de arduino
        private void tmrSend_Tick(object sender, EventArgs e)
        {
            //Vraag de arduino om waardes terug te sturen (zoals de ldr waarde)
            sendSignal("s");
        }

        //Het verwerken van de signalen die de applicatie ontvangt van de arduino
        private void tmrRecieve_Tick(object sender, EventArgs e)
        {
            if (serialPortArduino.IsOpen)
            {
                //De arduino stuurt signalen via println. Dit voegt een \r toe aan de string
                arduinoSignal = arduinoSignal.Replace("\r", "");
                lblPower.Text = "Power: " + arduinoSignal + "%";
                //De arduino kan een verkeerde waarde sturen. In dit geval crasht te applicatie niet dankzij try { }
                try
                {
                    if (arduinoSignal.Length > 0)
                    {
                        pbPower.Value = Convert.ToInt32(arduinoSignal);
                    }
                }
                catch { }
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            //Het bericht "p" voor power zet de attractie aan/uit
            if (serialPortArduino.IsOpen)
            {
                sendSignal("p");
                serialPortArduino.Close();
                closeControlPanel();
            }
            else
            {
                try
                {
                    serialPortArduino.Open();
                    if (serialPortArduino.IsOpen)
                    {
                        sendSignal("p");
                        openControlPanel();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    
        private void trkbrSpeed_Scroll(object sender, EventArgs e)
        {
            findSelectedPortConfig().speed = trkbrSpeed.Value;
            sendSignal(findSelectedPortConfig().speed.ToString());
            lblSpeed.Text = "Snelheid: " + trkbrSpeed.Value.ToString();

            if (trkbrSpeed.Value == 1)
            {
                start.Play();
            }
            else if (trkbrSpeed.Value == 2)
            {
                snel.Play();
            }
            else if (trkbrSpeed.Value == 3)
            {
                sneller.Play();
            }
            else if (trkbrSpeed.Value == 4)
            {
                turbo.Play();
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            draaien.Play();

            if (findSelectedPortConfig().reverse)
            {
                btnReverse.BackColor = Color.Red;
                findSelectedPortConfig().reverse = false;
            }
            else
            {
                btnReverse.BackColor = Color.Green;
                findSelectedPortConfig().reverse = true;
            }
            sendSignal(findSelectedPortConfig().reverse.ToString());
        }
        #endregion

        #region Audio
        private void btnSnel_Click(object sender, EventArgs e)
        {
            snel.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start.Play();
        }
        #endregion

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Battery
        private void tmrBattery_Tick(object sender, EventArgs e)
        {
            //Bekijkt the waarde van de scrollbar en aanpast int value.
            if (serialPortArduino.IsOpen)
            {
                lblBatterij.Text = Convert.ToInt32(batterijPercentage).ToString();
                pbBatterij.Value = Convert.ToInt32(batterijPercentage);

                switch(trkbrSpeed.Value)
                {
                    case 1:
                        batterijPercentage += .1m;
                        break;
                    case 2:
                        batterijPercentage += .05m;
                        break;
                    case 3:
                        batterijPercentage -= .03m;
                        break;
                    case 4:
                        batterijPercentage -= .05m;
                        break;
                }
            }
            
            //In geval van batterijen leeg alles uit.
            if (batterijPercentage <= -0.1m)
            {
                serialPortArduino.Close();
                closeControlPanel();
                start.Stop();
                snel.Stop();
                sneller.Stop();
                turbo.Stop();
            }
        }
        #endregion
    }
}
