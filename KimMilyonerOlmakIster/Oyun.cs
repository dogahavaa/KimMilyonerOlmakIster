using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KimMilyonerOlmakIster
{
    internal class Oyun
    {
        public ArrayList sorular { get; set; }
        public double toplam;
        public double kesinPara;


        public Oyun()
        {
            sorular = new ArrayList();
            toplam = 0;
            kesinPara = 0;
        }

        public void SoruEkle(string metin, string[] secenekler, string dogruCevap, double soruDegeri)
        {
            Soru s = new Soru(metin, secenekler, dogruCevap, soruDegeri);
            sorular.Add(s);
        }

        public void SoruGoster()
        {
            for (int i = 0; i < sorular.Count; i++)
            {
                Console.WriteLine("Toplam Para = " + toplam + " TL");
                Soru soru = (Soru)sorular[i];

                Console.WriteLine((i+1) + ". Soru : "  + soru.metin);

                for (int j = 0; j < soru.secenekler.Length; j++)
                {
                    string secenek = "";
                    switch (j)
                    {
                        case 0:
                            secenek = "A";
                            break;
                        case 1:
                            secenek = "B";
                            break;
                        case 2:
                            secenek = "C";
                            break;
                        case 3:
                            secenek = "D";
                            break;
                    }
                    Console.Write(secenek + ") " + soru.secenekler[j] + " ");
                }
                Console.WriteLine();

                string gelenCevap = Console.ReadLine();

                if (gelenCevap == soru.dogruCevap)
                {
                    Console.WriteLine("Helal");
                    toplam += soru.soruDegeri;
                    kesinPara = toplam;
                }
                else
                {
                    Console.WriteLine("gg");
                    Console.WriteLine("Kazandığın para = 0 TL" );
                    break;
                }

                Console.WriteLine("Parayı almak ister misiniz ?");
                Console.WriteLine("E : Parayı al kaç");
                Console.WriteLine("H : Devamke");
                string devamMi = Console.ReadLine();

                if(devamMi == "H")
                {
                    kesinPara = toplam;
                }
                else if(devamMi == "E")
                {
                    Console.WriteLine("Kazanılan para : " + kesinPara + " TL");
                    break;
                }
            }
        }
    }

   


}
