using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace feleves3
{
    internal class Kerdes
    {
        public string[][] Kerdesek
        {
            get;
        }

        public Kerdes()
        {
            Kerdesek = Beolvasas();
        }

        public string[][] Beolvasas()
        {
            string[][] eredmeny = new string[15][];
            StreamReader sr = new StreamReader("kerdesek.csv", Encoding.UTF8);
            int i = 0;
            while (!sr.EndOfStream)
            {
                eredmeny[i] = new string[7];
                int j = 0;
                while (j < eredmeny[i].Length)
                {
                    eredmeny[i][j] = sr.ReadLine();
                    j++;
                }
                i++;
            }
            sr.Close();
            return eredmeny;
        }

        public void Kiiras(Jatekos jatekos, Nyeremeny n, Ranglista r)
        {
            Console.Clear();
            jatekos.Nyeremeny = 0;
            n.Osszeg = 0;

            Segitseg s = new Segitseg();
            bool nyert = false;
            bool megall = false;
            int mutato = 0;
            int i = 0;
            while (i < Kerdesek.Length)
            {

                n.Kiiras(n);
                s.DbKiiras(n);

                int j = 0;
                while (j < Kerdesek[i].Length - 1)
                {
                    //Console.WriteLine(Kerdesek[i][j]);
                    //j++;

                    if (!BeolvasasRosszE(Kerdesek[i]))
                    {
                        Console.WriteLine(Kerdesek[i][j]);
                        j++;
                    }
                    else
                    {
                        i++;
                        Console.WriteLine(Kerdesek[i][j]);
                        j++;
                    }
                }

                string valasz = HelyesE();

                if (valasz.Length == 1)
                {
                    if (valasz == Kerdesek[i][6] && i <= 13)
                    {
                        n.Novel(i);

                        string folytat = "";
                        if (i > 4)
                        {
                            folytat = FolytatE();
                            if (folytat == "i")
                            {
                                Console.Clear();
                                i++;
                                mutato++;
                            }
                            else
                            {
                                megall = true;
                                i = Kerdesek.Length;
                            }
                        }
                        else
                        {
                            Console.Write("\nHelyes válasz. Nyomj Entert a folytatáshoz!");
                            Console.ReadLine();
                            Console.Clear();
                            i++;
                            mutato++;
                        }

                        if (i == 4)
                        {
                            Console.WriteLine("Elérted az első mentési pontot! Ha helyesen válaszolsz biztosan nyersz valamennyit.");
                        }
                        if (i == 9)
                        {
                            Console.WriteLine("Elérted a második mentési pontot! Tovább növelheted a biztos nyereményedet.");
                        }
                        n.BiztosNyeremeny(i, n);
                    }
                    else if (valasz == Kerdesek[i][6] && i == 14)
                    {
                        i = 15;
                        nyert = true;
                        jatekos.Nyeremeny = 50000000;
                    }
                    else
                    {
                        i = Kerdesek.Length;
                    }
                }
                else
                {
                    MilyenSegitseg(valasz, s, Kerdesek[i], i, n);
                    valasz = segitsegEseten(s, Kerdesek[i], i, n);

                    if (valasz == Kerdesek[i][6] && i <= 13)
                    {
                        n.Novel(i);

                        string folytat = "";
                        if (i > 4)
                        {
                            folytat = FolytatE();
                            if (folytat == "i")
                            {
                                Console.Clear();
                                i++;
                                mutato++;
                            }
                            else
                            {
                                megall = true;
                                i = Kerdesek.Length;
                            }
                        }
                        else
                        {
                            Console.Write("\nHelyes válasz. Nyomj Entert a folytatáshoz!");
                            Console.ReadLine();
                            Console.Clear();
                            i++;
                            mutato++;
                        }

                        if (i == 4)
                        {
                            Console.WriteLine("Elérted az első mentési pontot! Ha helyesen válaszolsz biztosan nyersz valamennyit.");
                        }
                        if (i == 9)
                        {
                            Console.WriteLine("Elérted a második mentési pontot! Tovább növelheted a biztos nyereményedet.");
                        }
                        n.BiztosNyeremeny(i, n);
                    }
                    else if (valasz == Kerdesek[i][6] && i == 14)
                    {
                        i = 15;
                        nyert = true;
                        jatekos.Nyeremeny = 50000000;
                    }
                    else
                    {
                        i = Kerdesek.Length;
                    }
                }
            }

            jatekos.MennyitNyer(mutato, nyert, megall);
            r.Hozzadas(jatekos);

            if (nyert)
            {
                jatekos.Nyert(s);
            }
            else if (megall)
            {
                jatekos.Megall(mutato);
            }
            else
            {
                jatekos.Vesztett(mutato);
            }

        }

        public string HelyesE()
        {
            string valasz = "";
            do
            {
                Console.Write("\rMi a helyes válasz [a/b/c/d/telefon/felező/közönség]: ");
                valasz = Console.ReadLine();

            } while (valasz != "a" && valasz != "b" && valasz != "c" && valasz != "d" && valasz != "telefon" && valasz != "felezo" && valasz != "közönség");
            return valasz;
        }

        public string FolytatE()
        {
            string valasz = "";
            do
            {
                Console.Write("\nHelyes válasz! Folytatod a játékot [i/n]? ");
                valasz = Console.ReadLine();
            } while (valasz != "i" && valasz != "n");
            return valasz;
        }

        public void MilyenSegitseg(string valasz, Segitseg s, string[] aktualisKerdes, int i, Nyeremeny n)
        {
            if (valasz == "telefon")
            {
                if (!s.TelefonHasznaltE)
                {
                    s.Telefon(aktualisKerdes);
                    s.Felhasznalva++;
                }
                else
                {
                    Console.WriteLine("\nEzt a segítséget már elhasználtad!\n");
                }
            }
            else if (valasz == "közönség")
            {
                if (!s.KozonsegHasznaltE)
                {
                    s.Kozonseg(i, aktualisKerdes[6]);
                    s.Felhasznalva++;
                }
                else
                {
                    Console.WriteLine("\nEzt a segítséget már elhasználtad!\n");
                }
            } 
            else if (valasz == "felezo")
            {
                if (!s.FelezoHasznaltE)
                {
                    s.Felezo(aktualisKerdes, n, s);
                    s.Felhasznalva++;
                }
                else
                {
                    Console.WriteLine("\nEzt a segítséget már elhasználtad!\n");
                }
            }
        }

        public string segitsegEseten(Segitseg s, string[] aktalisKerdes, int i, Nyeremeny n)
        {
            string valasz2 = "";
            do
            {
                Console.Write("Mi a helyes válasz [a/b/c/d/telefon/felező/közönség]: ");
                valasz2 = Console.ReadLine();

                if (valasz2 == "telefon" || valasz2 == "felezo" || valasz2 == "közönség")
                {
                    MilyenSegitseg(valasz2, s, Kerdesek[i], i, n);
                }
            } while (valasz2 != "a" && valasz2 != "b" && valasz2 != "c" && valasz2 != "d");
            return valasz2;
        }

        public bool BeolvasasRosszE(string[] kerdesTomb)
        {
            for (int i = 0; i < kerdesTomb.Length; i++)
            {
                if (kerdesTomb.Length < 7 || kerdesTomb[i] == "")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
