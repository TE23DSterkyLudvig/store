

using System.Numerics;

int start = 100;
int morot = 15;
int gurka = 10;
int köttbiff = 25;
string val = "";
int antalmorotnum = 0;
string antalmorot = "";
string antalgurka = "";
int antalgurkanum = 0;
string antalkött = "";
int antalköttnum = 0;
int totalmorot = 0;
int totalgurka = 0;
int totalkött  = 0;
//int morotkost = antalnum * morot;
//int gurkkost = antalnum * gurka;
//int köttkost = antalnum * köttbiff;

string filepath = @"C:\Users\ludvig.sterky\Documents\progggrogg\store\store\trollFace";
string info = File.ReadAllText(filepath);


System.Console.WriteLine("Du har 100 kronor från början");
while (start > 0)
{
    System.Console.WriteLine("Du handlar och kan välja mellan morot, köttbiff och gurka. Vad vill du ha?");
    System.Console.WriteLine(info);
    val = Console.ReadLine();

    List<string> foods = ["gurka", "morot", "köttbiff"];

    while (foods.Contains(val) == false)
    {
        val = Console.ReadLine();
    }

    if (val.ToLower() == "morot")
    {
        System.Console.WriteLine("Hur många morötter vill du köpa?");
        antalmorot = Console.ReadLine();
    }
    else if (val.ToLower() == "gurka")
    {
        System.Console.WriteLine("Hur många Gurkor vill du köpa?");
        antalgurka = Console.ReadLine();
    }
    else if (val.ToLower() == "köttbiff")
    {
        System.Console.WriteLine("Hur många Köttbiffar vill du köpa?");
        antalkött = Console.ReadLine();
    }
    //System.Console.WriteLine("Hur många vill du köpa?");
    //string antal =Console.ReadLine();

    //int.TryParse(antal, out antalnum);
    int.TryParse(antalmorot, out antalmorotnum);
    int.TryParse(antalgurka, out antalgurkanum);
    int.TryParse(antalkött, out antalköttnum);

    int morotkost = antalmorotnum * morot;
    int gurkkost = antalgurkanum * gurka;
    int köttkost = antalköttnum * köttbiff;

    if (val.ToLower() == "morot")
    {
        System.Console.WriteLine($"Du köper {antalmorotnum} morötter och det kostar {morotkost}");
        start -= morotkost;
        totalmorot += antalmorotnum;
    }
    if (val.ToLower() == "gurka")
    {
        System.Console.WriteLine($"Du köper {antalgurkanum} gurkor och det kostar {gurkkost}");
        start -= gurkkost;
        totalgurka += antalgurkanum;
    }
    if (val.ToLower() == "köttbiff")
    {
        System.Console.WriteLine($"Du köper {antalköttnum} köttbiffar och det kostar{köttkost}");
        start -= köttkost;
        totalkött += antalköttnum;
    }
     start = Math.Max(0, start);
}
int morotkost2 = antalmorotnum * morot;
int gurkkost2 = antalgurkanum * gurka;
int köttkost2 = antalköttnum * köttbiff;
if (start <= 0)
{
    System.Console.WriteLine("Du har slut på pengar");
    System.Console.WriteLine($"Du köpte {totalmorot} morötter, {totalgurka} gurkor och {totalkött} köttbiffar.");
}

Console.ReadLine();

// Skriv ut alternativen
// Läs in valet
// Välj pris beroende på valet
// Läs in antal som ska köpas
//  (gör om till int)
// Räkna ut totalpris