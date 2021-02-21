using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
     class MyDictionary<Tip1,Tip2>
    {
        Tip1[] AnahtarKelime;
        Tip2[] Ozellik;

        public MyDictionary()
        {
            AnahtarKelime = new Tip1[0];
            Ozellik = new Tip2[0];
        }

        public void Add(Tip1 anahtar,Tip2 ozellik)
        {
            Tip1[] tempTip1 = AnahtarKelime;
            Tip2[] tempTip2 = Ozellik;

            AnahtarKelime = new Tip1[tempTip1.Length + 1];
            for (int i = 0; i < AnahtarKelime.Length; i++)
            {
                AnahtarKelime[i] = tempTip1[i];
            }
            AnahtarKelime[AnahtarKelime.Length - 1] = anahtar;

            Ozellik = new Tip2[tempTip2.Length + 1];
            for (int i = 0; i < Ozellik.Length; i++)
            {
                Ozellik[i] = tempTip2[i];
            }
            Ozellik[Ozellik.Length - 1] = ozellik;

            Console.WriteLine(anahtar+"     "+ozellik);
        }


    }
}
