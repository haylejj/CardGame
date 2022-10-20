using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu2
{
    internal class Cards
    {
        public string tür;
        public string sayidegeri;
        public int puan;

        public void ShowCard()
        {
            Console.WriteLine("{0}--{1}--{2}\n",tür,sayidegeri,puan);
        }
    }
}
