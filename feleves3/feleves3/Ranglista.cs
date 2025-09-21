using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feleves3
{
    internal class Ranglista
    {
        private Jatekos[] jatekosok;
        private int eddigHany;

        public Ranglista()
        {
            jatekosok = new Jatekos[0];
        }

        public void Hozzadas(Jatekos j)
        {
            Jatekos[] ujtomb = new Jatekos[jatekosok.Length + 1];
            for (int i = 0; i < jatekosok.Length; i++)
            {
                ujtomb[i] = jatekosok[i];
            }

            Jatekos ujJatekos = new Jatekos();
            ujJatekos.Nev = j.Nev;
            ujJatekos.Nyeremeny = j.Nyeremeny;
            
            
            ujJatekos.Idopont = DateTime.Now;
            ujJatekos.Helyezes = ++eddigHany;

            //próba ha egyenlő a nyeremény!
            //if (ujtomb.Length >= 2)
            //{
            //    for (int k = 0; k < ujtomb.Length; k++)
            //    {
            //        if (ujJatekos.Nyeremeny == ujtomb[ujtomb.Length - 2].Nyeremeny)
            //        {
            //            ujJatekos.Helyezes = ujtomb[ujtomb.Length - 2].Helyezes;
            //        }
            //    }
            //}
            //else
            //{
            //    ujJatekos.Helyezes = ++eddigHany;
            //}

            ujtomb[ujtomb.Length - 1] = ujJatekos;
            jatekosok = ujtomb;
        }

        public Jatekos[] VisszaAd()
        {
            for (int i = 0; i < jatekosok.Length - 1; i++)
            {
                for (int q = i + 1; q < jatekosok.Length; q++)
                {
                    if (jatekosok[i].Nyeremeny < jatekosok[q].Nyeremeny)
                    {
                        Jatekos tmp = jatekosok[i];
                        jatekosok[i] = jatekosok[q];
                        jatekosok[q] = tmp;

                        int tmp2 = jatekosok[i].Helyezes;
                        jatekosok[i].Helyezes = jatekosok[q].Helyezes;
                        jatekosok[q].Helyezes = tmp2;
                    }
                }
            }
            return jatekosok;
        }
    }
}
