using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMilyonerOlmakIster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun();

            oyun.SoruEkle("Hangi gezegen bir gezegendir", new string[] { "Gezegen", "Gezemeyen", "Gezmek İstemeyen", "G" }, "D", 3);
            oyun.SoruEkle("Hangi sanatçı ülkemizi Eurovision'da temsil etmiştir ?", new string[] { "Ankaralı Namık", "Ciguli", "Kapıcı İzzet", "Aleyna Baba" }, "C", 7.5);
            oyun.SoruEkle("Soru", new string[] { "Anonim", "Senin Anonim", "kuesçın", "ensır" }, "B", 4);
            oyun.SoruEkle("Cevap", new string[] { "Fişne suyu", "Şalgam", "Şarap", "Şavran" }, "D", 0.25);
            oyun.SoruEkle("Milyonluk soru", new string[] { "Sen 300 milyon", "milyar", "sen ne yaptın", "bi susar mısın lo" }, "D", 1);

            


            oyun.SoruGoster();
        }
    }
}
