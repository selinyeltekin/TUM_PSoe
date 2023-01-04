// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Please enter your  name and surname: ");
string name, surname;
name = Console.ReadLine();  
surname = Console.ReadLine();
Console.WriteLine("ad:"+ name + "\nsoyad:"+ surname);
*/


/*string konu, saat, yer;
Console.WriteLine("Lutfen podcast konusunu giriniz: ");
konu = Console.ReadLine();
Console.WriteLine("Lutfen podcast saatini giriniz: ");
saat = Console.ReadLine();
Console.WriteLine("Lutfen podcast yeri giriniz:");
yer = Console.ReadLine();
Console.WriteLine("konusu: " + konu + "\nsaati: " + saat + "\nyeri: " + yer);
*/

/*int number;
Console.WriteLine("please enter a number: ");
//number =int.Parse(Console.ReadLine());  
number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("number:"+ number);  */

int anne, baba, cocuk1, cocuk2, average;
Console.WriteLine("enter anne yas: ");
anne=int.Parse(Console.ReadLine());
Console.WriteLine("enter baba yas: ");
baba = int.Parse(Console.ReadLine());
Console.WriteLine("enter cocuk1 yas: ");
cocuk1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter cocuk2 yas: ");
cocuk2 = int.Parse(Console.ReadLine());
average=(anne+baba+cocuk1+cocuk2)/4; //kullanıcıdan almadıgım ıcın ıntegerı strınge donusturmedım.
Console.WriteLine("anne yas: " + anne+ "\nbabayas: " +baba+"\ncocuk1 yas: " + cocuk1+"\ncocuk2: " +cocuk2 + "\naverage: " +average );

