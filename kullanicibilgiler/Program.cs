using System;

namespace usersInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lütfen tc kimlik numaranızı girin");
            
            //tc kimlik numaraları 11 hanelidir int32 bit için olan  max 2,147,483,648 değeri aştığı için long veri tipi tanımlandı
            
            long tcNo = Convert.ToInt64 (Console.ReadLine());
            
            Console.WriteLine("lütfen adınızı giriniz");
            
            string name = Console.ReadLine();
            
            Console.WriteLine("lütfen soy adınızı girin");
            
            string lastName = Console.ReadLine();
            
            Console.WriteLine("lütfen telefon numaranızı girin");
            
            //telefon numaraları 10 haneli int32 bit değerini aşabileceği için long tanımlandı
            
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("lütfen yaşınızı girin");
            
            //yaşlar tam sayı olduğu için int veri tipi tanımlandı 
            
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("lütfen ilk aldığınız ürünün fiyatını girin");
            
            //ürün fiyatları küsüratlı veya ondalıklı ifadeler içebileceği için double veri tipi tanımlandı
            
            double firstProduct = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("lütfen ikinci aldığınız ürünün fiyatını giriniz");
            
            //ürün fiyatları küsüratlı veya ondalıklı ifadeler içebileceği için double veri tipi tanımlandı
            
            double secondProduct = Convert.ToDouble(Console.ReadLine());

            double discount = (firstProduct + secondProduct) * 10 / 100;

            Console.WriteLine($@"{tcNo} TC numaralı {name} {lastName} isimli kişi için kayıt oluşturulmuştur.
{phoneNumber} telefon numarasına bildirim gönderilmiştir.
{firstProduct + secondProduct} toplam harcama karşılığı kazanilan %10 patika miktarı > {discount} TL dir");
        }
    }
}