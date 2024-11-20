
string adi;//string ile yazılabilir karakterler atadım//
string soyadi;
string ogrencinumarasi;
string telefonnumarasi;

Console.Write("İsminizi Girin: ");//kullanıcıları kişisel verilerini sordum//
adi = Console.ReadLine();
Console.Write("Soyadınızı Girin: ");
soyadi = Console.ReadLine();
Console.Write("Öğrenci Numaranızı Girin: ");
ogrencinumarasi = Console.ReadLine();
Console.Write("Telefon Numaranızı Girin: ");
telefonnumarasi = Console.ReadLine();

Console.WriteLine("\nisim: " +  adi + " Soyadı: " + soyadi + " Öğrenci Numarası: " + ogrencinumarasi + " Telefon Numarası: " + telefonnumarasi);//stringleri atayıp + komutu ile istenilenleri yazdım//
Console.ReadKey();//altta yazan kısmın kalkması için//