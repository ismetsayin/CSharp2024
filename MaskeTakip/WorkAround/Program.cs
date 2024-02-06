using Business.Concrete;
using Entities.Concrete;

SelamVer(isim: "ismet");
SelamVer(isim: "hazim");
SelamVer(isim: "ahmet");
SelamVer();
int sonuc = Topla();

string ogrenci1 = "ismet";
string ogrenci2 = "hazim";
string ogrenci3 = "ahmet";

string[] ogrenciler = new string[2];
ogrenciler[0] = "ismet";
ogrenciler[1] = "ahmet";

ogrenciler = new string[4];
ogrenciler[3] = "hazim";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Konya", "İstanbul", "Trabzon" };
string[] sehirler2 = new[] { "Ankara", "Hatay", "Mersin" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "İsmet";
person1.LastName = "Sayın";
person1.DateOfBirthYear = 1996;
person1.NationalIdentity = 12345678910;

Person person2 = new Person();
person2.FirstName = "Demir";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//generic collection
List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");
foreach (string sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

static void SelamVer(string isim = "isimsiz")

{
    Console.WriteLine("Merhaba " + isim);
}
static int Topla(int sayi1 = 10, int sayi2 = 15)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}