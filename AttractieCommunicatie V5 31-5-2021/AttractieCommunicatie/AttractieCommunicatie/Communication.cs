using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AttractieCommunicatie
{
    static class Communication
    {
        internal static int NumberOfRetries = 0;
        internal static string signal { get; set; }
        public static bool signalTimedOut = false;
        static Timer timeoutTimer = new Timer();

        //Maak variabele startchar, eindchar en magic nummer aan
        //Geen return in het midden van een functie
        //Timeout tijd toevoegen

        public static bool sendSignal(string _signal)
        {
            if (Config.MainPort.IsOpen)
            {
                Communication.signal = _signal;
                try
                {
                    //BELANGRIJK: DE SIGNALEN BEGINNEN MET EEN AANDUIDING VOOR WAT ER INGESTELD DIENT TE WORDEN (eg: speed = 3). DIT MOET DUS VERWERKT WORDEN NAAR EEN STRING VAN CHAR SIGNALEN.
                    //De volgende signalen kunnen verstuurd worden; 'speed=0/1/2/3/4', 'power=True/False', 'reverse=True/False' en 'send'
                    Config.MainPort.Write("#" + _signal + "%");

                    if (!timeoutTimer.Enabled && !signal.StartsWith("power"))
                    {
                        timeoutTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                        timeoutTimer.Interval = 1000;
                        timeoutTimer.Enabled = true;
                    }

                    return true;
                }
                catch (Exception ex)
                { 
                }
            }
            return false;
        }

        public static bool recieveSignal()
        {
            if (Config.MainPort.IsOpen )
            {
                timeoutTimer.Enabled = false;

                string arduinoSignal = Config.MainPort.ReadLine();
                //De arduino stuurt signalen via println. Dit voegt een \r toe aan de string
                arduinoSignal = arduinoSignal.Replace("\r", "");

                if (arduinoSignal == "NACK" || arduinoSignal == null)
                {
                    NumberOfRetries++;
                    if (NumberOfRetries > 2)
                    {
                        NumberOfRetries = 0;
                        return false;
                    }
                    sendSignal(signal);
                    return true;
                }
                else if (arduinoSignal == "ACK")
                {
                    NumberOfRetries = 0;
                    return true;
                }

                //In het geval dat signal een int is (voor ldr waarde)
                else
                {
                    //De arduino kan een opstart waarde sturen. In dit geval crasht te applicatie niet dankzij try { }
                    try
                    {
                        Arduino.ldrValue = Convert.ToInt32(arduinoSignal);
                        return true;
                    }
                    catch { }
                }
            }
            return false;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            signalTimedOut = true;
            timeoutTimer.Enabled = false;
        }
    }
}
