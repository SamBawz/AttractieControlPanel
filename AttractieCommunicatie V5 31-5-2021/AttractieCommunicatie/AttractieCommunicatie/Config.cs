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
        public static SerialPort usedPort { get; set; }

        public List<Port> getPorts()
        {
            List<Port> ports = new List<Port>();
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
            {
                Port _port = new Port(port, 2, false, 0);
                ports.Add(_port);
            }
            return ports;
        }
    }
}
