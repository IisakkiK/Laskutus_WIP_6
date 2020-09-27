using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directory = "C:\\temp";

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        string[] asiakkaat = Directory.GetFiles(directory);

        for (int i = 0; i < asiakkaat.Length; i++)
        {
            string edit = asiakkaat[i].Replace("C:\\temp\\", "");
            edit = edit.Replace(".txt", "");
            asiakkaat[i] = edit;
        }

        Tulosta(asiakkaat);


        static void Tulosta(string[] asiakkaat)
        {
            foreach (string file in asiakkaat)
            {
                File.ReadAllText(file);
                Console.WriteLine(file);
            }
        }
    }
}
