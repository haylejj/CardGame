using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu2
{
    internal class Game
    {
        Pack destemiz=new Pack();

        public int o1p=0;
        public int o2p=0;

        public void Start()
        {
            destemiz.Create();
            destemiz.Mix();
        }
        public void Play()
        {
            Cards o1k1 = destemiz.PullCard();
            Cards o1k2 = destemiz.PullCard();
            
            Cards o2k1= destemiz.PullCard();
            Cards o2k2= destemiz.PullCard();

            Console.WriteLine("Oyuncu1'in Eli\n");
            o1k1.ShowCard();
            o1k2.ShowCard();
            o1p = o1k1.puan + o1k2.puan;
            Console.WriteLine("Oyuncu 1 Puan:{0}\n", o1p);

            Console.WriteLine("Oyuncu 2'in Eli\n");
            o2k1.ShowCard();
            o2k2.ShowCard();
            o2p= o2k1.puan + o2k2.puan;
            Console.WriteLine("Oyuncu 2 Puan:{0}\n", o2p);

            if (o1p > o2p)
            {
                Console.WriteLine("Oyuncu 1 Kazandı\n");
            }
            else if (o1p < o2p)
            {
                Console.WriteLine("Oyuncu 2 Kazandı\n");
            }
            else
            {
                Console.WriteLine("Berabere\n");
            }
        }
    }
}
