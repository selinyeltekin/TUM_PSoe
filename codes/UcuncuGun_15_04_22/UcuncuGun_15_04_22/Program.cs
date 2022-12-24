// See https://aka.ms/new-console-template for more information
/*string yer, zaman, icecek;
Console.WriteLine("Mekani giriniz: ");
yer=Console.ReadLine();
Console.WriteLine("Zamani giriniz: ");
zaman=Console.ReadLine();   
Console.WriteLine("Icecek nedir: ");
icecek=Console.ReadLine();
Console.WriteLine("yer:" + yer + "\nzaman" + zaman + "\nicecek" + icecek);*/

/*string sehir;
Console.WriteLine("bir sehir giriniz:");
sehir = Console.ReadLine();

if (sehir == "istanbul")
{
    Console.WriteLine("türkiyenin en büyük iki ilinden birini girdiniz");
}
else if(sehir == "ankara"){
    Console.WriteLine("başkenti girdiniz");

}
else
{
    Console.WriteLine("giediğiniz şehir hakkında bilgi yok");
}
*/

int sinav1, sinav2, ortalama;
Console.WriteLine("ilk sinav notunu gir: ");
sinav1 = int.Parse(Console.ReadLine());
Console.WriteLine("ikinci sinav notunu gir: ");
sinav2 = int.Parse(Console.ReadLine());
ortalama = (sinav1+sinav2)/2;

if (ortalama >= 50)
{
    Console.WriteLine("Gectiniz!!!!");
}
else
{
    Console.WriteLine("Kaldiniz");
}



