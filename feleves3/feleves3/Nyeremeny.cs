using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feleves3
{
    internal class Nyeremeny
    {
        public int Osszeg { get; set; }

        public Nyeremeny()
        {
            Osszeg = 0;
        }

        public void Novel(int i)
        {
            switch (i)
            {
                case 0:
                    Osszeg = 10000;
                    break;
                case 1:
                    Osszeg = 20000;
                    break;
                case 2:
                    Osszeg = 50000;
                    break;
                case 3:
                    Osszeg = 100000;
                    break;
                case 4:
                    Osszeg = 250000;
                    break;
                case 5:
                    Osszeg = 500000;
                    break;
                case 6:
                    Osszeg = 750000;
                    break;
                case 7:
                    Osszeg = 1000000;
                    break;
                case 8:
                    Osszeg = 1500000;
                    break;
                case 9:
                    Osszeg = 2000000;
                    break;
                case 10:
                    Osszeg = 5000000;
                    break;
                case 11:
                    Osszeg = 10000000;
                    break;
                case 12:
                    Osszeg = 15000000;
                    break;
                case 13:
                    Osszeg = 25000000;
                    break;
                case 14:
                    Osszeg = 50000000;
                    break;
                default:
                    Osszeg = 0;
                    break;
            }
        }

        public void Kiiras(Nyeremeny n)
        {
            string alakit = stringgeAlakit(n);
            Console.SetCursorPosition((Console.WindowWidth - alakit.Length) / 2, Console.CursorTop);
            Console.WriteLine("Nyeremény: " + alakit);
        }

        public void BiztosNyeremeny(int i, Nyeremeny n)
        {
            string alakit = stringgeAlakit(n);
            if (i >= 5 && i < 9)
            {
                Console.SetCursorPosition((Console.WindowWidth - alakit.Length) / 2, Console.CursorTop);
                Console.WriteLine("Biztos nyeremény: 250.000 Ft");
            }
            else if (i >= 10)
            {
                Console.SetCursorPosition((Console.WindowWidth - alakit.Length) / 2, Console.CursorTop);
                Console.WriteLine("Biztos nyeremény: 2.000.000 Ft");
            }
            
        }

        public string stringgeAlakit(Nyeremeny n)
        {
            string uj = "";
            switch (n.Osszeg)
            {
                case 0:
                    uj = "0 Ft";
                    break;
                case 10000:
                    uj = "10.000 Ft";
                    break;
                case 20000:
                    uj = "20.000 Ft";
                    break;
                case 50000:
                    uj = "50.000 Ft";
                    break;
                case 100000:
                    uj = "100.000 Ft";
                    break;
                case 250000:
                    uj = "250.000 Ft";
                    break;
                case 500000:
                    uj = "500.000 Ft";
                    break;
                case 750000:
                    uj = "750.000 Ft";
                    break;
                case 1000000:
                    uj = "1.000.000 Ft";
                    break;
                case 1500000:
                    uj = "1.500.000 Ft";
                    break;
                case 2000000:
                    uj = "2.000.000 Ft";
                    break;
                case 5000000:
                    uj = "5.000.000 Ft";
                    break;
                case 10000000:
                    uj = "10.000.000 Ft";
                    break;
                case 15000000:
                    uj = "15.000.000 Ft";
                    break;
                case 25000000:
                    uj = "25.000.000 Ft";
                    break;
                case 50000000:
                    uj = "50.000.000 Ft";
                    break;
                default:
                    break;
            }
            return uj;
        }
    }
}
