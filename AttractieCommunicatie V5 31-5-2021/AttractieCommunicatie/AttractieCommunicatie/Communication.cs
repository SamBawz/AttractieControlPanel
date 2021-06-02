using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractieCommunicatie
{
    static class Communication
    {
        internal static int NACKnumber = 0;
        internal static string signal { get; set; }

        public static bool sendSignal(string _signal)
        {
            Communication.signal = _signal;
            try
            {
                //BELANGRIJK: DE SIGNALEN BEGINNEN MET EEN AANDUIDING VOOR WAT ER INGESTELD DIENT TE WORDEN (eg: speed = 3). DIT MOET DUS VERWERKT WORDEN NAAR EEN STRING VAN CHAR SIGNALEN.
                //De volgende signalen kunnen verstuurd worden; 'speed=0/1/2/3/4', 'power=true/false', 'reverse=true/false' en 'send'
                Config.usedPort.Write("#" + _signal + "%");
                return true;
            }
            catch (Exception ex)
            { 
                return false;
            }
        }

        public static bool recieveSignal()
        {
            if (Config.usedPort.IsOpen)
            {
                string arduinoSignal = Config.usedPort.ReadLine();
                //De arduino stuurt signalen via println. Dit voegt een \r toe aan de string
                arduinoSignal = arduinoSignal.Replace("\r", "");

                if (arduinoSignal == "NACK")
                {
                    NACKnumber++;
                    if (NACKnumber > 3)
                    {
                        return false;
                    }
                    sendSignal(signal);
                    return true;
                }
                else if (arduinoSignal == "ACK")
                {
                    NACKnumber = 0;
                    return true;
                }

                //In het geval dat signal een int is (voor ldr waarde)
                else
                {
                    //De arduino kan een opstart waarde sturen. In dit geval crasht te applicatie niet dankzij try { }
                    try
                    {
                        Arduino.ldrValue = Convert.ToInt32(arduinoSignal);
                    }
                    catch { }
                }
            }
            return false;
        }
    }
}
