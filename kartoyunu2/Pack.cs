using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu2
{
    internal class Pack
    {
        Cards[] kartlar = new Cards[52];

        public void Create()
        {
            string[] turler = new string[4] { "Maço", "Karo", "Sinek", "Kupa" };
            string[] degerler = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Q", "J", "K" };
            int[] puanlar = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 11 };
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    kartlar[k] = new Cards();
                    kartlar[k].tür=turler[i];
                    kartlar[k].sayidegeri=degerler[j];
                    kartlar[k].puan=puanlar[j];
                    k++;
                }
            }
        }

        public void Mix()
        {
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int rIndes=random.Next(0,52);
                Cards gecici = kartlar[i];
                kartlar[i]=kartlar[rIndes];
                kartlar[rIndes] = gecici;
            }
        }
        int cekilenKS = 0;
        public Cards  PullCard()
        {
            return kartlar[cekilenKS++];
        }



    }
}
