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
        public static bool power
        {
            get
            {
                return power;
            }
            set
            {
                Communication.sendSignal("power = " + value.ToString());
                power = value;
            }
        }

        public static int speed
        {
            get 
            {
                return speed;
            }
            set
            {
                Database.updateDatabase("speed", value.ToString());
                Communication.sendSignal("speed = " +  value.ToString());
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
                Database.updateDatabase("forward", value.ToString());
                Communication.sendSignal("reverse = " + value.ToString());
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
                Database.updateDatabase("light", ldrValue.ToString());
                ldrValue = value;
            }
        }


        public static bool togglePower()
        {
            if(Config.usedPort.IsOpen)
            {
                power = false;
                Config.usedPort.Close();
                return false;
            }
            else
            {
                try
                {
                    Config.usedPort.Open();
                    if (Config.usedPort.IsOpen)
                    {
                        power = true;
                        return true;
                    }
                }
                catch (Exception ex)
                {
                }
                return false;
            }
        }

        public static bool reverseAttraction()
        {
            if (reverse)
            {
                reverse = false;
                return false;
            }
            else
            {
                reverse = true;
                return true;
            }
        }


    }
}
