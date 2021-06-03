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
        //Fields to save settings after setting properties. Setting a property from within the same property causes a loop.
        private static bool _power = false;
        private static int _speed = 0;
        private static bool _reverse = false;
        private static int _ldrValue;
        private static decimal _battery = 10;

        public static bool power
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
                Communication.sendSignal("power=" + _power.ToString());
            }
        }

        public static int speed
        {
            get 
            {
                return _speed;
            }
            set
            {
                _speed = value;
                Database.updateDatabase("UPDATE solarcoasterstats SET speed = '" + _speed.ToString() + "'");
                Communication.sendSignal("speed=" + _speed.ToString());
            }
        }

        public static bool reverse
        {
            get
            {
                return _reverse;
            }
            set
            {
                _reverse = value;
                if (_reverse)
                {
                    Database.updateDatabase("UPDATE solarcoasterstats SET forward = '" + 1 + "'");
                }
                else {
                    Database.updateDatabase("UPDATE solarcoasterstats SET forward = '" + 0 + "'");
                }
            }
        }

        public static int ldrValue
        {
            get
            {
                return _ldrValue;
            }
            set
            {
                _ldrValue = value;
                Database.updateDatabase("UPDATE solarcoasterstats SET light = '" + _ldrValue + "'");
            }
        }

        public static decimal battery
        {
            get
            {
                return _battery;
            }
            set
            {
                _battery = value;
                //Database.updateDatabase("UPDATE solarcoasterstats SET light = '" + _ldrValue + "'");
            }
        }


        public static bool togglePower()
        {
            if (Config.MainPort != null)
            {
                if (Config.MainPort.IsOpen)
                {
                    power = false;
                    Config.closeMainPort();
                    return false;
                }
                else
                {
                    try
                    {
                        if (Config.openMainPort())
                        {
                            power = true;
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            return false;
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

        public static decimal calculatePower()
        {
            decimal loss = 0m;
            decimal gain = ldrValue * .01m;

            switch (Arduino.speed)
            {
                case 1:
                    loss = .00m;
                    break;
                case 2:
                    loss = .4m;
                    break;
                case 3:
                    loss = .8m;
                    break;
                case 4:
                    loss = 1.2m;
                    break;
            }

            Arduino.battery = Arduino.battery + gain - loss;

            //In geval van batterijen leeg alles uit.
            if (Arduino.battery <= -0.1m)
            {
                Arduino.togglePower();
            }

            return Arduino.battery;
        }
    }
}
