using System;
using System.Threading;

namespace ZH2_20SasváriB_SM_NSz_SzV_MesterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            //Készítette Szili Viktória, Németh Szabolcs, Sasvári Bendegúz, Sallai Martin
            //attól hogy piros működik, ez valami bugg


            kezdökép(); //main beli hívás a kezdőkép alprogramhoz
            szabály(); //Main beli hívás a Szabály alprogramhoz
            string nev = GetPlayerName(); //start

            do
            {
                Play(nev);
                Console.ForegroundColor //A Game over magentára való színezése
           = ConsoleColor.Magenta;
                Console.Write("\n JÁTÉK VÉGET ÉRT ! \n***********************\n** G A M E _ O V E R **\n***********************"); //a játéknak vége
            }
            while (Console.ReadLine().ToUpper() == "Igen"); //ha igen akkor folytatás
        }
        static void szabály() //Szabályok: Szili Viktória **********************************************************************
        {
            Console.ForegroundColor //Szabályok
           = ConsoleColor.Red;
            Console.WriteLine("*************  SZABÁLYOK:  **************");
            Console.WriteLine("TALÁLT: EZ AZT JELENTI HOGY ELTALÁLTAD AZ EGGYIK KARAKTERT");
            Console.WriteLine("NEM TALÁLT: EZ AZT JELENTI HOGY NINCS BENNE A KERESETT SZÁMBAN ");
            Console.WriteLine("ROSZ HELYEN VAN : EZ AZT JELENTI HOGY VAN A KÓDBAN OLYAN SZÁM CSAK MÁS HELYEN");
            Thread.Sleep(3000);
            Console.ForegroundColor
           = ConsoleColor.White;
            Console.Clear();
        }
        static void kezdökép() //Kezdőkép: Szili Viktória********************************************************
        {   //Start kreditek
            Console.WriteLine("************** Kezdjük a Mester Mind játékot **************\n");
            Console.WriteLine("Készítette Szili Viktória, Németh Szabolcs, Sasvári Bendegúz, Sallai Martin MérnökInf FOSZK");
            Console.WriteLine("************************************************");
            Console.WriteLine("**           ZH 2. | 2020.dec 1.              **");
            Console.WriteLine("**Készítette Szili Viktória, Németh Szabolcs,***");
            Console.WriteLine("**       Sasvári Bendegúz, Sallai Martin      **");
            Console.WriteLine("**          Mérnök. Informatka FOSZK          **");
            Console.WriteLine("************************************************");
            Thread.Sleep(3000);
            Console.Clear();
        }

        private static void Play(string name) //alprogram 1 //Sallai Martin & Németh Szabolcs*****************************************************
        {
            int numberCount = GetRandomNumberCount();
            Console.Write(numberCount + " karakterből áll a számod. Kezdjük"); //meg add egy random számot


            int[] PCArray = GenerateRandomNumbers(numberCount); //random szám generátor
            Console.WriteLine("A {0}-karakteből álló számot választottál. Minden egyes karakter 1 és 4 közötti szám.\n", numberCount); //lehet 4-10 karakterből álló számot választani.

            int difficulty = GetGameDifficulty(); // nehézségi szint választás
            Console.Clear();

            bool nyer = false; //Németh Szabolcs***********************************************************************************************
            for (int allowedAttempts = difficulty * numberCount; allowedAttempts > 0 && !nyer; allowedAttempts--)
            {
                Console.WriteLine("\nÜss be egy tippet ({0} tipped maradt hátra)", allowedAttempts); //ennyi tipped maradt hátra

                int[] userArray = GetUserGuess(numberCount);

                if (CountHits(PCArray, userArray) == numberCount)
                    nyer = true;
            }

            if (nyer) //Sasvári Bendegúz******************************************************************************************

                Console.WriteLine("Nyertél, {0}!", name); //nyertél yey
            else
                Console.WriteLine("Oho neeee, {0}! Nem találtad ki XD.", name); //vesztettél


            Console.Write("A szám valójában: "); //amire a gép gondolt
            for (int j = 0; j < numberCount; j++)
                Console.Write(PCArray[j] + " ");

        }

        private static string GetPlayerName() //alprogram 2 Szili Viki*************************************************************
        {
            Console.Write("Írd be a neved: "); //neved?
            string nev = Console.ReadLine();
            Console.WriteLine("Üdvözöllek, {0}. \n", nev); //vissza köszön
            return nev;
        }

        public static int GetRandomNumberCount() //alprogram 3 Sallai Martin******************************************************************
        {
            int szam;

            Console.Write("Irja be hogy 4 karakterrel szeretne játszani !"); //mekkora számmal szeretnél játszani
            while (!int.TryParse(Console.ReadLine(), out szam) || szam < 4 || szam > 5)
                Console.WriteLine("válasz újra, ez nem jó"); //ha 4 és 10 között van akkor jó ha kevesebb vagy több akkor ezt írja

            return szam;
        }

        public static int GetGameDifficulty() //alprogram 4 Németh Szabolcs*****************************************************************************
        {
            int difficulty = 0;

            Console.Write("Válassz nehézségi szintet: (1=nehéz, 2=közepes, 3=könnyű): "); //nehézségi szint választás
            while (!int.TryParse(Console.ReadLine(), out difficulty) || difficulty < 1 || difficulty > 3)
                Console.WriteLine("Rossz válasz! Válassz a 3 szám közül."); //ha elgépelné az ember

            return difficulty;
        }



        public static int[] GetUserGuess(int userSize) //alprogram 6 Sasvári Bendegúz*******************************************************************
        {
            int szam = 0;
            int[] userGuess = new int[userSize]; //tömb
            for (int i = 0; i < userSize; i++)
            {
                Console.Write("Szám: {0}: ", (i + 1));  ///tippek: 
                while (!int.TryParse(Console.ReadLine(), out szam) || szam < 1 || szam > 4)
                    Console.WriteLine("nem jó szám!"); //ha 1vagy 4nél kissebbet// nagyobbat ütne valaki
                userGuess[i] = szam;

            }



            for (int i = 0; i < userSize; i++)
            {
                Console.Write(userGuess[i] + " ");
            }

            return userGuess;
        }

        public static int CountHits(int[] PCArray, int[] userArray) //alprogram 7 Sallai Martin ****************************************************
        {

            Console.Write("Amire te gondoltál: "); //amire a játékos gondol:
            int talalat = 0;
            int roszhely = PCArray.Length;
            int segéd = 0;
            int i = 0;

            for (i = 0; i < PCArray.Length; i++)  //Sasvári Bendegúz***************************************************************************
            {
                if (PCArray[i] == userArray[i])
                    talalat++;
                if (PCArray[0] != userArray[i] && PCArray[i] == userArray[i])
                {
                    segéd++;
                }
                if (PCArray[1] != userArray[i] && PCArray[i] == userArray[i])
                {
                    segéd++;
                }
                if (PCArray[2] != userArray[i] && PCArray[i] == userArray[i])
                {
                    segéd++;
                }
                if (PCArray[3] != userArray[i] && PCArray[i] == userArray[i])
                {
                    segéd++;
                }
            }
            if (userArray[0] == userArray[1] && userArray[0] == userArray[2] && userArray[0] == userArray[3])
            {
                roszhely = 0;

            }
            else
            {

                roszhely = segéd - talalat + (PCArray.Length - talalat);

                for (i = 0; i < PCArray.Length; i++)
                {
                    if (PCArray[0] == userArray[0] && PCArray[1] == userArray[1] && PCArray[2] == userArray[2] && PCArray[3] == userArray[3])
                    {
                        roszhely = 0;
                    }
                }


            }






            Console.WriteLine("A megoldás: {0} Talált ,{1} rosz helyen van, {2} nem talált ", talalat, roszhely, PCArray.Length - talalat);

            return talalat; //a megoldások Szili viki****************************************************************************************
        }
        public static int[] GenerateRandomNumbers(int PCSize) //alprogram 5 //Szili Viki*******************************************************
        {
            int eachNumber;  //random szám generátor
            int[] randomNumber = new int[PCSize];
            Random rnd = new Random();

            //Console.Write("A számítógép által megadott szám: "); //mire gondolt a gép: 
            for (int i = 0; i < PCSize; i++)
            {
                eachNumber = rnd.Next(1, 5);
                randomNumber[i] = eachNumber;
                //Console.Write(eachNumber);
            }

            return randomNumber;
        }
    }
}
