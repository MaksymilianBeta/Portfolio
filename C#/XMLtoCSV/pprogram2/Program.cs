using System;
using System.IO;

namespace TiFWD
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nazwa_pliku;
            string plik_XML = "";
            string plik_konwersja = "";
            string nazwa_gry;
            string data_wydania;
            string wersja;
            string kat_wiek;
            string kat_gry;
            string plik_CSV;


            Console.WriteLine("Witaj w programie do importu XML");
            Console.WriteLine("Będę pobierał plik z: " + sciezka);
            Console.WriteLine("Podaj nazwę pliku: ");
            nazwa_pliku = Console.ReadLine();
            if (nazwa_pliku == "") { nazwa_pliku = "Plik_XML.xml"; }
            plik_XML = File.ReadAllText(sciezka + "\\" + nazwa_pliku);
            Console.WriteLine(plik_XML);
            plik_konwersja = plik_XML;


            //plik_XML = plik_XML.Remove(0, plik_XML.IndexOf(">")+1);
            plik_konwersja = plik_konwersja.Replace("<?xml version=\"1.0\" encoding=\"UTF-8\"?>", "");

            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            nazwa_gry = plik_konwersja.Substring(0, plik_konwersja.IndexOf("<"));
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            data_wydania = plik_konwersja.Substring(0, plik_konwersja.IndexOf("<"));
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            wersja = plik_konwersja.Substring(0, plik_konwersja.IndexOf("<"));
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            kat_wiek = plik_konwersja.Substring(0, plik_konwersja.IndexOf("<"));
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            plik_konwersja = plik_konwersja.Remove(0, plik_konwersja.IndexOf(">") + 1);
            kat_gry = plik_konwersja.Substring(0, plik_konwersja.IndexOf("<"));


           // Console.WriteLine(plik_konwersja);
           // Console.WriteLine(nazwa_gry);
           // Console.WriteLine(data_wydania);
           // Console.WriteLine(wersja);
           // Console.WriteLine(kat_wiek);
           // Console.WriteLine(kat_gry);
           // Console.WriteLine(plik_XML);

            plik_CSV = "Nazwa;Data_wydania;Wersja;kat_wiek;kat_gry;\r\n";
            Console.WriteLine("\r\n"+"Plik CSV:\r\n" + plik_CSV);

            plik_CSV = plik_CSV + nazwa_gry + ";" + data_wydania + ";" + wersja + ";" + kat_wiek + ";" + kat_gry + ";";
            Console.WriteLine("\r\n" + plik_CSV);

            File.WriteAllText(sciezka + "\\Plik.CSV.csv", plik_CSV);


            Console.ReadKey();
        }

    }

}
