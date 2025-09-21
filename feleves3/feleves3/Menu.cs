using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feleves3
{
    internal class Menu
    {
        public void Megnyitas()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            string s = "Menü megnyitása...";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.Write(s);

            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine("Legyen Ön is milliomos!");
            Console.WriteLine("\n1 - Új játék");
            Console.WriteLine("2 - Ranglista");
            Console.WriteLine("3 - Játék bezárása");
        }

        public int MenuValasztas()
        {
            int opcio;
            do
            {
                Console.Write("Válassz egy menüpontot [1, 2 vagy 3]: ");
                opcio = int.Parse(Console.ReadLine());
            } while (opcio != 1 && opcio != 2 && opcio != 3);
            return opcio;
        }

        public void Kilepes()
        {
            Console.Clear();
            string s = "Játék bezárása...";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.Write(s);
            Thread.Sleep(1500);
        }

        public void Szabalyok()
        {
            Console.Clear();
            Console.WriteLine("JÁTÉKSZABÁLYOK: ");
            Console.WriteLine("- 15 kérdésre kell helyes választ adni, 4 válaszlehetőség lesz mindegyikhez [a/b/c/d] és a segítségek!");
            Console.WriteLine("- 3 segítséget tudsz felhasználni a játék folyamán, de mindegyiket csak egyszer!");
            Console.WriteLine("- Minden helyes válasz után pénzt kapsz ami automatikusan hozzáadódik a nyereményedhez!");
            Console.WriteLine("- FIGYELJ, hogy csak az 5. és a 10. kérdés után van mentési pont. Ha a kettő között/előtt állsz meg vagy esel ki, az előző mentési pontnál birtokolt nyereményt szerzed csak meg!");

            Console.Write("\nNyomj Entert a folytatáshoz!");
            Console.ReadLine();
            Console.WriteLine();
            for (int i = 3; i >= 1; i--)
            {
                Console.Write("\rA játék kezdődik {0}", i);
                Thread.Sleep(1000);
            }
        }

    }
}
