using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttractieCommunicatie
{
    class Sound
    {
        public string Start { get; set; }
        public string Snel { get; set; }
        public string Sneller { get; set; }
        public string Turbo { get; set; }
        public string Draaien { get; set; }


        //System.Media.SoundPlayer aSneller = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Sneller"]);
        //static System.Media.SoundPlayer aStart = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Start"]);
        static List<System.Media.SoundPlayer> sounds = new List<System.Media.SoundPlayer>()
        {
            new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Start"]),
            new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Snel"]),
            new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Sneller"]),
            new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Turbo"]),
            new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Draaien"]),
        };


        public Sound(string _start, string _snel, string _sneller, string _turbo, string _draaien)
        {
            this.Start = _start;
            this.Snel = _snel;
            this.Sneller = _sneller;
            this.Turbo = _turbo;
            this.Draaien = _draaien;
        }

        public static bool aStart()
        {
            foreach (System.Media.SoundPlayer sound in sounds)
            {
                if (sound.SoundLocation == ConfigurationSettings.AppSettings["Start"])
                {
                    sound.Play();
                }
            }
            return false;
        }

        public static bool aSnel()
        {
            foreach (System.Media.SoundPlayer sound in sounds)
            {
                if (sound.SoundLocation == ConfigurationSettings.AppSettings["Snel"])
                {
                    sound.Play();
                }
            }
            return false;
        }

        public static bool aSneller()
        {
            foreach (System.Media.SoundPlayer sound in sounds)
            {
                if (sound.SoundLocation == ConfigurationSettings.AppSettings["Sneller"])
                {
                    sound.Play();
                }
            }
            return false;
        }

        public static bool aTurbo()
        {
            foreach (System.Media.SoundPlayer sound in sounds)
            {
                if (sound.SoundLocation == ConfigurationSettings.AppSettings["Turbo"])
                {
                    sound.Play();
                }
            }
            return false;
        }

        public static bool aDraaien()
        {
            foreach (System.Media.SoundPlayer sound in sounds)
            {
                if (sound.SoundLocation == ConfigurationSettings.AppSettings["Draaien"])
                {
                    sound.Play();
                }
            }
            return false;
        }

        public static void aStopAll()
        {
            foreach (System.Media.SoundPlayer sound in sounds)
            {
                sound.Stop();
            }
        }
    }
}
