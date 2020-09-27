using System;
using System.IO;

namespace Laskutus_WIP_5 // Testikommentti_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tervetuloa Laskutusohjelmistoon.\nVersio: 0.06\n\nPaina mitä tahansa näppäintä jatkaaksesi");

            Console.ReadKey();

            CreateMainMenu();
        }

        /// <summary>
        /// Luo Päävalikon lähettämällä "Menu" -classille stringinä parametrit, jotka asetetaan menun itemeiksi.
        /// </summary>
        static void CreateMainMenu()
        {
            Console.Clear();

            Menu mainMenu = new Menu("1. Asiakas", "2. Raportti", "3. Lopeta", "", "");

            Console.WriteLine(mainMenu.CreateMenu());
            char choice = Console.ReadKey(true).KeyChar;

            if (choice == '1')
            {
                CreateCustomerMenu();
            }
            else if (choice == '2')
            {
                Console.Clear();
                Console.WriteLine("UNDER CONSTRUCTION");

                Console.ReadKey(true);
                CreateMainMenu();
            }
            else if (choice == '3')
            {
                return;
            }
            else
            {
                CreateMainMenu();
            }
        }

        /// <summary>
        /// Luo Päävalikon lähettämällä "Menu" -classille stringinä parametrit, jotka asetetaan menun itemeiksi.
        /// </summary>
        static void CreateCustomerMenu()
        {
            Console.Clear();

            Menu customerMenu = new Menu("1. Tarkastele asiakkaita", "2. Lisää asiakas", "3. Poista asiakas", "4. Palaa takaisin", "");

            Console.WriteLine(customerMenu.CreateMenu());
            char choice = Console.ReadKey(true).KeyChar;

            if (choice == '1')
            {
                ListCustomers();
            }
            else if (choice == '2')
            {
                Console.Clear();
                Console.WriteLine("UNDER CONSTRUCTION");

                Console.ReadKey(true);
                CreateCustomerMenu();
            }
            else if (choice == '3')
            {
                Console.Clear();
                Console.WriteLine("UNDER CONSTRUCTION");

                Console.ReadKey(true);
                CreateCustomerMenu();
            }
            else if (choice == '4')
            {
                CreateMainMenu();
            }
            else
            {
                CreateCustomerMenu();
            }
        }

        /// <summary>
        /// Tarkistaa onko C:\temp -kansio olemassa, jos ei; luo sen. Tekee files nimisen taulukon, johon asettaa kaikki tiedostot, jotka löytyvät C:\temp -kansiosta.
        /// Korvaa jokaisessa alkiossa olevan tiedostopolun alun (C:\temp\) ja lopun (.txt) tyhjällä merkillä, jotta asiakasnimet saataisiin eriytettyä näistä.
        /// </summary>
        private static void ListCustomers()
        {
            string directory = "C:\\temp";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string[] files = Directory.GetFiles(directory);

            for (int i = 0; i < files.Length; i++)
            {
                string edit = files[i].Replace("C:\\temp\\", "");
                edit = edit.Replace(".txt", "");
                files[i] = edit;
            }

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();

            CreateCustomerMenu();
        }
    }
}
