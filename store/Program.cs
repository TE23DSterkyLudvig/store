using System.Runtime.CompilerServices;

int start = 100;
int morot = 15;
int gurka = 10;
int köttbiff = 25;
string val = "";
int antalnum = 0;

System.Console.WriteLine("Du handlar och kan välja mellan morot, köttbiff och gurka. Vad vill du ha?");
val = Console.ReadLine();
System.Console.WriteLine("Hur många vill du köpa?");
string antal =Console.ReadLine();

int.TryParse(antal, out antalnum);

if()

// Skriv ut alternativen
// Läs in valet
// Välj pris beroende på valet
// Läs in antal som ska köpas
//  (gör om till int)
// Räkna ut totalpris