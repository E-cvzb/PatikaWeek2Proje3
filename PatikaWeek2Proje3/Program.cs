
//while

int sayaç = 1;//1 den başlıyoruz çünkü sayaçlarda eşitlik olduğu için 
Console.WriteLine("Lütfen bir sayı giriniz");
int sayı = Convert.ToInt32(Console.ReadLine());

while (sayaç<=sayı)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayaç++;//sayaç değerini artırıyoruz 
}

// do whilw 
int sayaç2 = 1;

Console.WriteLine("Lütfen bir sayı giriniz"); 
int sayı2 = Convert.ToInt32(Console.ReadLine());
do
{


    if (sayaç2 <= sayı2)
    {
        Console.WriteLine("Ben bir Patika'lıyım");
        sayaç2++;// sayaç 2 değerini artırıyoruz
        
    }
    else
    {
        break;//sayaç değeri sayı değerini geçerse döngüyü sonlandırır
    }

} while (sayaç2 <= sayı2);

//While yazmak daha kolaydı do while da dönü için bir de if kullanmamız gerekiyor

    
  

