using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMilyonerOlmakIster
{
    internal class Soru
    {
        public string metin { get; set; }
        public string[] secenekler { get; set; }
        public string dogruCevap { get; set; }
        public double soruDegeri { get; set; }

        public Soru(string metin, string[] secenekler, string dogruCevap, double soruDegeri)
        {
            this.metin = metin;
            this.secenekler = secenekler;
            this.dogruCevap = dogruCevap;
            this.soruDegeri = soruDegeri;
        }


    }
}
