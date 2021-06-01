using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractieCommunicatie
{
    static class Communication
    {
        public static bool sendSignal(string signal)
        {
            try
            {
                //BELANGRIJK: DE SIGNALEN BEGINNEN MET EEN AANDUIDING VOOR WAT ER INGESTELD DIENT TE WORDEN (eg: speed = 3). DIT MOET DUS VERWERKT WORDEN NAAR EEN STRING VAN CHAR SIGNALEN.
                //De volgende signalen kunnen verstuurd worden; 'speed = 1/2/3/4/5', 'power = true/false', 'reverse = true/false' en 'send'
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
