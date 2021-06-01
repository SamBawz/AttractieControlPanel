using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AttractieCommunicatie
{
    static class Arduino
    {   
        public static int speed
        {
            get
            {
                return speed;
            }
            set
            {
                Database.updateDatabase("speed", value.ToString());
                //DIT GAAT LATER BEHANDELD WORDEN IN DE COMMUNICATIE KLASSE!!
                sendSignal(Config.usedPort, value.ToString());
                speed = value;
            }
        }

        public static bool reverse
        {
            get
            {
                return reverse;
            }
            set
            {
                if (value == true)
                {
                    Database.updateDatabase("forward", "true");
                }
                else if (value == false)
                {
                    Database.updateDatabase("forward", "false");
                }
                
                //DIT GAAT LATER BEHANDELD WORDEN IN DE COMMUNICATIE KLASSE!!
                sendSignal(Config.usedPort, value.ToString());

                reverse = value;
            }
        }

        public static int ldrValue
        {
            get
            {
                return ldrValue;
            }
            set
            {
                Database.updateDatabase("light", ldrValue);
                ldrValue = value;
            }
        }


        public static bool togglePower(SerialPort port)
        {
            if(port.IsOpen)
            {
                Arduino.sendSignal(port, "p");
                port.Close();
                return false;
            }
            else
            {
                try
                {
                    port.Open();
                    if (port.IsOpen)
                    {
                        Arduino.sendSignal(port, "p");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                }
                return false;
            }
        }

        /// <summary>
        /// Stuurt een signaal naar de gekozen poort
        /// </summary>
        /// /// <param name="port">De poort waar het bericht naar verstuurd wordt</param>
        /// <param name="signal">Het bericht dat verstuurd dient te worden</param>
        public static bool sendSignal(string signal)
        {
            //sendCommand
            try
            {
                Config.usedPort.Write(signal);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string recieveSignal()
        {
            if (Config.usedPort.IsOpen)
            {
                string arduinoSignal = Config.usedPort.ReadLine();
                //De arduino stuurt signalen via println. Dit voegt een \r toe aan de string
                arduinoSignal = arduinoSignal.Replace("\r", "");
                return arduinoSignal; 
            }
            return "";
        }
    }
}
