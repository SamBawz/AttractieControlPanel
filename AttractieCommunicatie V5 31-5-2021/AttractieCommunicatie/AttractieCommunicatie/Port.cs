using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractieCommunicatie
{
    class Port
    {
        public string portName { get; set; }
        public int speed { get; set; }
        public bool reverse { get; set; }
        public int ldrValue { get; set; }

        public Port(string name, int speed, bool reverse, int ldrvalue)
        {
            this.portName = name;
            this.speed = speed;
            this.reverse = reverse;
            this.ldrValue = ldrvalue;
        }
    }
}
