using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AttractieCommunicatie
{
    class Config
    {
        public static SerialPort MainPort { get; set; }

        //Wordt op dit moment niet gebruikt
        public List<Port> getPorts()
        {
            List<Port> ports = new List<Port>();
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
            { 
                Port _port = new Port(port);
                ports.Add(_port);
            }
            return ports;
        }

        public static void closeMainPort()
        {
            MainPort.Close();
        }

        public static bool openMainPort()
        {
            try
            {
                MainPort.Open();
                if (MainPort.IsOpen)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}
