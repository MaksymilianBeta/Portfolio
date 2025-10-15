using System.IO;


string naglowek = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";

string nazwa_gry = "";
string data_wydania = "";
string wersja = "";
string kategoria_wiekowa = "";
string kategoria_gry = "";
string nazwa_pliku = "Plik_XML.xml";

string sciezka = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

Console.WriteLine("Ścieżka do pulpitu to: " + sciezka);


Console.WriteLine("Podaj nazwe gry:");
nazwa_gry = Console.ReadLine();
if (nazwa_gry == "") { nazwa_gry = "Minecraft"; }

Console.WriteLine("Podaj date wydania: ");
data_wydania = Console.ReadLine();
if (data_wydania == "") { data_wydania = "2009"; }

Console.WriteLine("Podaj wersje gry: ");
wersja = Console.ReadLine();
if (wersja == "") { wersja = "1.8.8"; }

Console.WriteLine("Podaj kategorie wiekowa");
kategoria_wiekowa = Console.ReadLine();
if (kategoria_wiekowa == "") { kategoria_wiekowa = "7+"; }

Console.WriteLine("Podaj kategorie gry");
kategoria_gry = Console.ReadLine();
if (kategoria_gry == "") { kategoria_gry = "sandbox"; }

Console.WriteLine("Nazwa gry: " + nazwa_gry);
Console.WriteLine("Data wydania gry: " + data_wydania);
Console.WriteLine("wersja gry: " + wersja);
Console.WriteLine("kategoria wiekowa: " + kategoria_wiekowa);
Console.WriteLine("kategoria gry: " + kategoria_gry);

string plik_XML = $"<gra>\r\n<nazwa>{nazwa_gry}</nazwa>\r\n<data_wydania>{data_wydania}</data_wydania>\r\n<wersja>{wersja}</wersja>\r\n<kategoria_wiekowa>{kategoria_wiekowa}</kategoria_wiekowa>\r\n<kategoria_gry>{kategoria_gry}</kategoria_gry>\r\n</gra>";

plik_XML = naglowek + "\r\n" + plik_XML;


//Console.WriteLine(plik_XML);

Console.WriteLine("podaj nazwe pliku: ");
nazwa_pliku=Console.ReadLine();
if (nazwa_pliku == "") { nazwa_pliku ="Plik_XML.xml"; }

if (!nazwa_pliku.EndsWith(".xml")) { nazwa_pliku += ".xml"; }   
Console.WriteLine("Plik ma: " + plik_XML.Length + " znaków.");
//Console.WriteLine(plik_XML.IndexOf("<"));
//Console.WriteLine(plik_XML.LastIndexOf("<"));
//Console.WriteLine(plik_XML.LastIndexOf(">"));

//for (int i = 0; i < plik_XML.Length; i++) { Console.WriteLine(plik_XML[i].ToString()); }
/*
int licznik = 0;
for (int i = 0; i < plik_XML.Length; i++)
{
    if (plik_XML[i].ToString() == "<")
    { licznik++; }
}
*/
//Console.WriteLine(licznik.ToString());

Console.ReadKey();
File.WriteAllText(sciezka + "\\" + nazwa_pliku, plik_XML);
//Console.WriteLine

//StreamWriter zapisywanie = new StreamWriter("C:\\Users\\student\\Desktop\\pliczek2.xml");

//zapisywanie.WriteLine(plik_XML);
//zapisywanie.Close();
//zapisywanie.Dispose();
