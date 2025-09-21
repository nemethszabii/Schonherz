using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feleves3
{
    internal class Segitseg
    {
        static Random r;

        public int Darab { get; set; }

        public int Felhasznalva { get; set; }

        public bool TelefonHasznaltE { get; set; }

        public bool FelezoHasznaltE { get; set; }

        public bool KozonsegHasznaltE { get; set; }

        public Segitseg()
        {
            Darab = 3;
            r = new Random();
            KozonsegHasznaltE = false;
            FelezoHasznaltE = false;
            TelefonHasznaltE = false;
            Felhasznalva = 0;
        }

        public void DbKiiras(Nyeremeny n)
        {
            string alakit = n.stringgeAlakit(n);
            Console.SetCursorPosition((Console.WindowWidth - alakit.Length) / 2, Console.CursorTop);
            Console.WriteLine("Segítségeid száma: " + Darab);
        }

        public void Csokkent()
        {
            if (Darab > 0)
            {
                Darab -= 1;
            }
        }

        public void Kozonseg(int i, string helyesValasz)
        {
            Csokkent();
            KozonsegHasznaltE = true;

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int maradek = 0;
            switch (i)
            {
                case 0:
                    if (helyesValasz == "a")
                    {
                        a = 100;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 100;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 100;
                    }
                    else
                    {
                        d = 100;
                    }
                    break;
                case 1:
                    if (helyesValasz == "a")
                    {
                        a = 93;
                        b = 2;
                        c = 1;
                        d = 4;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 93;
                        a = 2;
                        c = 1;
                        d = 4;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 93;
                        b = 2;
                        a = 1;
                        d = 4;
                    }
                    else
                    {
                        d = 93;
                        b = 2;
                        c = 1;
                        a = 4;
                    }
                    break;
                case 2:
                    if (helyesValasz == "a")
                    {
                        a = 86;
                        b = 3;
                        c = 8;
                        d = 3;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 86;
                        a = 3;
                        c = 8;
                        d = 3;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 86;
                        b = 3;
                        a = 8;
                        d = 3;
                    }
                    else
                    {
                        d = 86;
                        b = 3;
                        c = 8;
                        a = 3;
                    }
                    break;
                case 3:
                    if (helyesValasz == "a")
                    {
                        a = 80;
                        b = 14;
                        c = 2;
                        d = 4;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 80;
                        a = 14;
                        c = 2;
                        d = 4;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 80;
                        b = 14;
                        a = 2;
                        d = 4;
                    }
                    else
                    {
                        d = 80;
                        b = 14;
                        c = 2;
                        a = 4;
                    }
                    break;
                case 4:
                    if (helyesValasz == "a")
                    {
                        a = 73;
                        b = 20;
                        c = 1;
                        d = 6;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 73;
                        a = 20;
                        c = 1;
                        d = 6;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 73;
                        b = 20;
                        a = 1;
                        d = 6;
                    }
                    else
                    {
                        d = 73;
                        b = 20;
                        c = 1;
                        a = 6;
                    }
                    break;
                case 5:
                    if (helyesValasz == "a")
                    {
                        a = 66;
                        b = 10;
                        c = 13;
                        d = 11;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 66;
                        a = 10;
                        c = 13;
                        d = 11;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 66;
                        b = 10;
                        a = 13;
                        d = 11;
                    }
                    else
                    {
                        d = 66;
                        b = 10;
                        c = 13;
                        a = 11;
                    }
                    break;
                case 6:
                    if (helyesValasz == "a")
                    {
                        a = 60;
                        b = 33;
                        c = 1;
                        d = 6;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 60;
                        a = 33;
                        c = 1;
                        d = 6;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 60;
                        b = 33;
                        a = 1;
                        d = 6;
                    }
                    else
                    {
                        d = 60;
                        b = 33;
                        c = 1;
                        a = 6;
                    }
                    break;
                case 7:
                    if (helyesValasz == "a")
                    {
                        a = 53;
                        b = 8;
                        c = 19;
                        d = 10;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 53;
                        a = 8;
                        c = 19;
                        d = 10;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 53;
                        b = 8;
                        a = 19;
                        d = 10;
                    }
                    else
                    {
                        d = 53;
                        b = 8;
                        c = 19;
                        a = 10;
                    }
                    break;
                case 8:
                    if (helyesValasz == "a")
                    {
                        a = 46;
                        b = 23;
                        c = 11;
                        d = 20;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 46;
                        a = 23;
                        c = 11;
                        d = 20;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 46;
                        b = 23;
                        a = 11;
                        d = 20;
                    }
                    else
                    {
                        d = 46;
                        b = 23;
                        c = 11;
                        a = 20;
                    }
                    break;
                case 9:
                    if (helyesValasz == "a")
                    {
                        a = 40;
                        b = 31;
                        c = 10;
                        d = 19;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 40;
                        a = 31;
                        c = 10;
                        d = 19;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 40;
                        b = 31;
                        a = 10;
                        d = 19;
                    }
                    else
                    {
                        d = 40;
                        b = 31;
                        c = 10;
                        a = 19;
                    }
                    break;
                case 10:
                    if (helyesValasz == "a")
                    {
                        a = 33;
                        b = 54;
                        c = 15;
                        d = 8;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 33;
                        a = 54;
                        c = 15;
                        d = 8;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 33;
                        b = 54;
                        a = 15;
                        d = 8;
                    }
                    else
                    {
                        d = 33;
                        b = 54;
                        c = 15;
                        a = 8;
                    }
                    break;
                case 11:
                    if (helyesValasz == "a")
                    {
                        a = 26;
                        b = 21;
                        c = 34;
                        d = 19;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 26;
                        a = 21;
                        c = 34;
                        d = 19;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 26;
                        b = 21;
                        a = 34;
                        d = 19;
                    }
                    else
                    {
                        d = 26;
                        b = 21;
                        c = 34;
                        a = 19;
                    }
                    break;
                case 12:
                    if (helyesValasz == "a")
                    {
                        a = 20;
                        b = 14;
                        c = 50;
                        d = 16;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 20;
                        a = 14;
                        c = 50;
                        d = 16;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 20;
                        b = 14;
                        a = 50;
                        d = 16;
                    }
                    else
                    {
                        d = 20;
                        b = 14;
                        c = 50;
                        a = 16;
                    }
                    break;
                case 13:
                    if (helyesValasz == "a")
                    {
                        a = 13;
                        b = 29;
                        c = 40;
                        d = 18;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 13;
                        a = 29;
                        c = 40;
                        d = 18;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 13;
                        b = 29;
                        a = 40;
                        d = 18;
                    }
                    else
                    {
                        d = 13;
                        b = 29;
                        c = 40;
                        a = 18;
                    }
                    break;
                case 14:
                    if (helyesValasz == "a")
                    {
                        a = 6;
                        b = 32;
                        c = 51;
                        d = 11;
                    }
                    else if (helyesValasz == "b")
                    {
                        b = 6;
                        a = 32;
                        c = 51;
                        d = 11;
                    }
                    else if (helyesValasz == "c")
                    {
                        c = 6;
                        b = 32;
                        a = 51;
                        d = 11;
                    }
                    else
                    {
                        d = 6;
                        b = 32;
                        c = 51;
                        a = 11;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"\nA közönség szavazatai [a: {a}% b: {b}% c: {c}% d: {d}%]");
            Console.WriteLine();
        }

        public void Felezo(string[] kerdes, Nyeremeny n, Segitseg s)
        {
            Console.Clear();
            Csokkent();
            FelezoHasznaltE = true;
            n.Kiiras(n);
            s.DbKiiras(n);

            string[] uj = new string[kerdes.Length - 3];
            int mutato = 0;
            int helyesIdx = HelyesValaszIdx(kerdes[6]);
            for (int i = 0; i < 2; i++)
            {
                uj[mutato] = kerdes[i];
                mutato++;
            }

            int rndIdx = Gen2(helyesIdx);
            if (helyesIdx > rndIdx)
            {
                uj[mutato] = kerdes[rndIdx];
                uj[mutato + 1] = kerdes[helyesIdx];
            }
            else if (helyesIdx < rndIdx)
            {
                uj[mutato] = kerdes[helyesIdx];
                uj[mutato + 1] = kerdes[rndIdx];
            }

            for (int j = 0; j < uj.Length; j++)
            {
                Console.WriteLine(uj[j]);
            }
        }

        public void Telefon(string[] aktualisKerdes)
        {
            Csokkent();
            TelefonHasznaltE = true;

            Console.WriteLine($"\nA telefonos segítség szerint a helyes válasz: {aktualisKerdes[6]}");
            Console.WriteLine();
        }

        public int HelyesValaszIdx(string helyesValasz) 
        {
            if (helyesValasz == "a")
            {
                return 2;
            }
            else if (helyesValasz == "b")
            {
                return 3;
            }
            else if (helyesValasz == "c")
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public int Gen2(int helyesValaszIdx)
        {
            int rnd = r.Next(2, 6);
            do
            {
                rnd = r.Next(2, 6);
            } while (rnd == helyesValaszIdx);
            return rnd;
        }
    }
}
