using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feleves3
{
    internal class Jatekos
    {
        public string Nev { get; set; }

        public int Nyeremeny { get; set; }

        public DateTime Idopont { get; set; }

        public int Helyezes { get; set; }

        public void Nyert(Segitseg s)
        {
            Console.Clear();
            Console.WriteLine("Gratulálok, sikerült az összes kérdésre helyesen válaszolnod!");
            Console.WriteLine($"Segítségek felhasználva: {s.Felhasznalva} db");
            Console.WriteLine("Nyeremény: 50.000.000 Ft");
            Console.Write("\nNyomj entert a menübe való visszatéréshez.");
            Console.ReadLine();
        }

        public void Megall(int i)
        {
            Console.Clear();
            if (i < 4)
            {
                Console.WriteLine("A megállást választottad. Sajnos nem nyertél most semmit de bármikor újrapróbálkozhatsz!");
                
            }
            else if (i >= 4 && i <= 9)
            {
                Console.WriteLine("A megállást választottad. A nyereményed 250.000 Ft.");
                
            }
            else if (i > 9 && i <= 13)
            {
                Console.WriteLine("A megállást választottad. A nyereményed 2.000.000 Ft.");
                
            }
            Console.Write("\nNyomj entert a menübe való visszalépéshez.");
            Console.ReadLine();
        }

        public void Vesztett(int i)
        {
            Console.Clear();
            if (i <= 4)
            {
                Console.WriteLine("Rosszul válaszoltál. Sajnos nem nyertél most semmit, de bármikor újrapróbálkozhatsz!");
                
            }
            else if (i > 4 && i <= 9)
            {
                Console.WriteLine("Sajnos rosszul válaszoltál, de nyertél 250.000 Ft-t.");           
            }
            else if (i > 9 && i <= 13)
            {
                Console.WriteLine("Sajnos rosszul válaszoltál, de nyertél 2.000.000 Ft-t.");
            }
            Console.Write("\nNyomj entert a menübe való visszalépéshez.");
            Console.ReadLine();
        }

        public void MennyitNyer(int mutato, bool nyert, bool megall)
        {
            if (!nyert)
            {
                switch (mutato)
                {
                    case 0:
                        Nyeremeny = 0;
                        break;
                    case 1:
                        Nyeremeny = 0;
                        break;
                    case 2:
                        Nyeremeny = 0;
                        break;
                    case 3:
                        Nyeremeny = 0;
                        break;
                    case 4:
                        if (megall)
                        {
                            Nyeremeny = 250000;
                        }
                        else
                        {
                            Nyeremeny = 0;
                        }
                        break;
                    case 5:
                        Nyeremeny = 250000;
                        break;
                    case 6:
                        Nyeremeny = 250000;
                        break;
                    case 7:
                        Nyeremeny = 250000;
                        break;
                    case 8:
                        Nyeremeny = 250000;
                        break;
                    case 9:
                        if (megall)
                        {
                            Nyeremeny = 2000000;
                        }
                        else
                        {
                            Nyeremeny = 250000;
                        }
                        break;
                    case 10:
                        Nyeremeny = 2000000;
                        break;
                    case 11:
                        Nyeremeny = 2000000;
                        break;
                    case 12:
                        Nyeremeny = 2000000;
                        break;
                    case 13:
                        Nyeremeny = 2000000;
                        break;
                    case 14:
                        Nyeremeny = 2000000;
                        break;
                    default:
                        Nyeremeny = 0;
                        break;
                } 
            }
            else
            {
                Nyeremeny = 50000000;
            }
        }
    }
}
