using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractieCommunicatie
{
    class Config
    {
        List<Port> myPorts = new List<Port>();
        public string SerialPort { get; set; }
        public string Port { get; set; }         
    }
}
