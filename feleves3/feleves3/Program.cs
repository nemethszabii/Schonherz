
using feleves3;

public class Program
{
    public static void Main(string[] args)
    {
        Kerdes k = new Kerdes();
        Jatekos j = new Jatekos();
        Nyeremeny n = new Nyeremeny();
        Ranglista r = new Ranglista();
        Menu m = new Menu();

        m.Megnyitas();

        int valasz = m.MenuValasztas();
        if (valasz == 1)
        {
            int opcio = 1;
            do
            {
                Console.Clear();
                if (opcio == 1)
                {
                    Console.Write("Add meg a neved: ");
                    j.Nev = Console.ReadLine();
                    m.Szabalyok();
                    k.Kiiras(j, n, r);
                    Console.Clear();
                }
                else if (opcio == 2)
                {
                    Jatekos[] tomb = r.VisszaAd();

                    for (int i = 0; i < tomb.Length; i++)
                    {
                        string szovegNyeremeny = StringgeAlakit(tomb[i].Nyeremeny);
                        Console.WriteLine($"{tomb[i].Helyezes}. {tomb[i].Nev} {szovegNyeremeny} {tomb[i].Idopont}");
                    }

                    Console.Write("\nNyomj Entert a menübe való visszalépéshez!");
                    Console.ReadLine();
                }
                opcio = MenuValasz();
            } while (opcio != 3);
            m.Kilepes();
        }
        else if (valasz == 2)
        {
            int opcio = 2;
            do
            {
                Console.Clear();
                if (opcio == 1)
                {
                    Console.Write("Add meg a neved: ");
                    j.Nev = Console.ReadLine();
                    m.Szabalyok();
                    k.Kiiras(j, n, r);
                    Console.Clear();
                }
                else if (opcio == 2)
                {
                    Jatekos[] tomb = r.VisszaAd();

                    if (tomb.Length == 0)
                    {
                        Console.WriteLine("Még nincs megjeleníthető adat a listában!");
                    }
                    else if (tomb.Length > 0)
                    {
                        for (int i = 0; i < tomb.Length; i++)
                        {
                            string szovegNyeremeny = StringgeAlakit(tomb[i].Nyeremeny);
                            Console.WriteLine($"{tomb[i].Helyezes}. {tomb[i].Nev} {szovegNyeremeny} {tomb[i].Idopont}");
                        }
                    }

                    Console.Write("\nNyomj Entert a menübe való visszalépéshez!");
                    Console.ReadLine();
                }
                opcio = MenuValasz();
            } while (opcio != 3);
            m.Kilepes();
        } 
        else if (valasz == 3)
        {
            m.Kilepes();
        }
    }

    static string StringgeAlakit(int osszeg)
    {
        string uj = "";
        switch (osszeg)
        {
            case 250000:
                uj = "250.000 Ft";
                break;
            case 2000000:
                uj = "2.000.000 Ft";
                break;
            case 50000000:
                uj = "50.000.000 Ft";
                break;
            default:
                uj = "0 Ft";
                break;
        }
        return uj;
    }

    static int MenuValasz()
    {
        Console.Clear();

        Console.WriteLine("Legyen Ön is milliomos!");
        Console.WriteLine("\n1 - Új játék");
        Console.WriteLine("2 - Ranglista");
        Console.WriteLine("3 - Játék bezárása");

        Console.Write("Válassz egy menüpontot [1, 2 vagy 3]: ");
        int opcio = 0;
        do
        {
            opcio = int.Parse(Console.ReadLine());
            Console.Write("Válassz újra! [1, 2 vagy 3]: ");
        } while (opcio != 1 && opcio != 2 && opcio != 3);
        return opcio;
    }

}