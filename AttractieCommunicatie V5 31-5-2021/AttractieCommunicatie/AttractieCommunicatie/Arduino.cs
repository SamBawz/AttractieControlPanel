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
        private static int _speed;
        private static bool _reverse;
        private static int _ldrValue;
        private static decimal _battery = Database.getBatteryLevel();

        public static bool power
        {
            get
            {
                return _power;
            }
            set
            {
                Arduino.speed = 0;
                Arduino.reverse = false;
                Arduino.ldrValue = 0;

                _power = value;
                if (_power)
                {
                    Database.updateSolarcoasterStats("Power", 1);
                }
                else
                {
                    Database.updateSolarcoasterStats("Power", 0);
                }
                Communication.sendSignal("power=" + value.ToString());
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
                Database.updateSolarcoasterStats("speed", value);
                Communication.sendSignal("speed=" + value.ToString());
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
                    Database.updateSolarcoasterStats("forward", 1);
                }
                else {
                    Database.updateSolarcoasterStats("forward", 0);
                }
                Communication.sendSignal("reverse=" + value.ToString());
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
                Database.updateSolarcoasterStats("ldr", value);
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
                Database.updateSolarcoasterStats("battery", Convert.ToString(value).Replace(",", "."));
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

        public static decimal calculateBatteryLevel()
        {
            decimal loss = 0m;
            decimal gain = ldrValue * .01m;
            decimal batteryLevel = 0m;

            switch (Arduino.speed)
            {
                case 0:
                    loss = .0m;
                    break;
                case 1:
                    loss = .3m;
                    break;
                case 2:
                    loss = .6m;
                    break;
                case 3:
                    loss = 0.9m;
                    break;
                case 4:
                    loss = 1.2m;
                    break;
            }

            batteryLevel = Arduino.battery + gain - loss;

            if (batteryLevel <= -0.1m)
            {
                Arduino.battery = 1;
                Arduino.togglePower();
            }
            else if (batteryLevel > 100)
            {
                Arduino.battery = 100;
            }
            else
            {
                Arduino.battery = batteryLevel;
            }

            return Arduino.battery;
        }
    }
}
