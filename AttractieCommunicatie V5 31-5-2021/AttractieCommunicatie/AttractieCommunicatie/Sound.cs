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
            System.Media.SoundPlayer aStart = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Start"]);
            List<System.Media.SoundPlayer> sounds = new List<System.Media.SoundPlayer>();

            sounds.Add(aStart);

            foreach (System.Media.SoundPlayer sound in sounds)
            {
                aStart.Play();
            }
            return false;
        }

        public static bool aSnel()
        {
            System.Media.SoundPlayer aSnel = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Snel"]);
            List<System.Media.SoundPlayer> sounds = new List<System.Media.SoundPlayer>();

            sounds.Add(aSnel);

            foreach (System.Media.SoundPlayer sound in sounds)
            {
                aSnel.Play();
            }
            return false;
        }

        public static bool aSneller()
        {
            System.Media.SoundPlayer aSneller = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Sneller"]);
            List<System.Media.SoundPlayer> sounds = new List<System.Media.SoundPlayer>();

            sounds.Add(aSneller);

            foreach (System.Media.SoundPlayer sound in sounds)
            {
                aSneller.Play();
            }
            return false;
        }

        public static bool aTurbo()
        {
            System.Media.SoundPlayer aTurbo = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Turbo"]);
            List<System.Media.SoundPlayer> sounds = new List<System.Media.SoundPlayer>();

            sounds.Add(aTurbo);

            foreach (System.Media.SoundPlayer sound in sounds)
            {
                aTurbo.Play();
            }
            return false;
        }

        public static bool aDraaien()
        {
            System.Media.SoundPlayer aDraaien = new System.Media.SoundPlayer(ConfigurationSettings.AppSettings["Draaien"]);
            List<System.Media.SoundPlayer> sounds = new List<System.Media.SoundPlayer>();

            sounds.Add(aDraaien);

            foreach (System.Media.SoundPlayer sound in sounds)
            {
                aDraaien.Play();
            }
            return false;
        }
    }
}
