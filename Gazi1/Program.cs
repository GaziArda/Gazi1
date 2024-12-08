using System;
using System.ComponentModel.Design;

namespace Gazi1
{
    internal class Program
    {
        //static int sayi = 5;
        static void Main(string[] args)


        {

            #region Değişkenler-Veri Yapıları
            //Değişkenler-Veri Yapıları



            //Console.WriteLine("Gazi");
            //Console.WriteLine("Üniversitesi");

            //const byte a=50;//Veri tipi:byte, ismi a
            //byte b;
            // a = 10;//a değişkenine değer ataması.
            //b = 20;
            //Console.WriteLine(a);
            //byte c = 30;

            //byte a = 30, b;
            //b = 40;

            //a = 50;

            //const int number = 50;

            //byte yas;
            //Console.WriteLine(yas);//Değeri olmayan değişkenler
            //hiç bir işlemde kullanılamaz

            // byte a = 10, b = 30, c;
            //c = a * b;

            //Console.WriteLine(c);

            //float sayi = 3.15f;

            //var sayi = 5.25;//Implicit (Veri tipinin açık belirtilmediği durum)
            //double number = 5.25;//Explicit (Veri tipinin açıkca belirtildiği durum)

            //char c = 'B'; 
            #endregion

            #region String Birleştirme İşlemleri
            //string isim = "Ahmet";
            //string soyad = "Mehmet";//Referans:soyad,Değeri:Mehmet


            //Console.WriteLine("Hoşgeldin, " + isim + " " + soyad);
            //Console.WriteLine("Hoşgeldin, {0} {1}", isim, soyad);
            //Console.WriteLine($"Hoşgeldin, {isim} {soyad}"); 
            #endregion

            #region Kullanıcı Etkileşimleri

            //Console.Write("İsminizi Giriniz:");
            //string isim = Console.ReadLine();
            //Console.Write("Soyadınızı Giriniz:");
            //string soyad = Console.ReadLine();

            //Console.WriteLine($"Hoşgeldin,\n{isim} {soyad}");
            #endregion


            #region Ödev 
            using System;

namespace Gazi1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Lütfen dil seçiniz\n1-Türkçe\n2-İngilizce");
                byte dil = byte.Parse(Console.ReadLine());
                switch (dil)
                {
                    case 1:
                        Console.WriteLine("Seçim yapınız\n1-Kare\n2-Üçgen\n3-Daire");
                        byte cisim = byte.Parse(Console.ReadLine());
                        switch (cisim)
                        {
                            case 1:
                                Console.WriteLine("Kare seçimi yaptınız. Alan/Çevre?");
                                string uzunluk = Console.ReadLine().ToLower().Trim();
                                if (uzunluk == "alan")
                                {
                                    Console.WriteLine("Karenin kenar uzunluğunu giriniz");
                                    int kenar1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Karenin alanı: {kenar1 * kenar1}");
                                }
                                else if (uzunluk == "çevre")
                                {
                                    Console.WriteLine("Karenin kenar uzunluğunu giriniz");
                                    int kenar2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Karenin çevresi: {kenar2 * 4}");
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen geçerli bir seçenek giriniz.");
                                }
                                break;

                            case 2:
                                Console.WriteLine("Üçgen seçimi yaptınız. Alan/Çevre?");
                                string üçgen = Console.ReadLine().ToLower().Trim();
                                if (üçgen == "alan")
                                {
                                    Console.WriteLine("Üçgenin yüksekliğini giriniz");
                                    int yükseklik = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Üçgenin taban uzunluğunu giriniz");
                                    int taban = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Üçgenin alanı: {taban * yükseklik / 2}");
                                }
                                else if (üçgen == "çevre")
                                {
                                    Console.WriteLine("Üçgenin 1. kenarını giriniz");
                                    int kenar1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Üçgenin 2. kenarını giriniz");
                                    int kenar2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Üçgenin 3. kenarını giriniz");
                                    int kenar3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Üçgenin çevresi: {kenar1 + kenar2 + kenar3}");
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen geçerli bir seçenek giriniz.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Daire seçimi yaptınız. Alan/Çevre?");
                                string daire = Console.ReadLine().ToLower().Trim();
                                if (daire == "alan")
                                {
                                    Console.WriteLine("Dairenin yarıçapını giriniz");
                                    int yaricap = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Dairenin alanı: {Math.PI * yaricap * yaricap}");
                                }
                                else if (daire == "çevre")
                                {
                                    Console.WriteLine("Dairenin yarıçapını giriniz");
                                    int yaricap = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Dairenin çevresi: {Math.PI * 2 * yaricap}");
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen geçerli bir seçenek giriniz.");
                                }
                                break;

                            default:
                                Console.WriteLine("Yanlış tuşlama yaptınız.");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Please make a selection\n1-Square\n2-Triangle\n3-Circle");
                        byte shape = byte.Parse(Console.ReadLine());

                        switch (shape)
                        {
                            case 1:
                                Console.WriteLine("You selected Square. Area/Perimeter?");
                                string length = Console.ReadLine().ToLower().Trim();
                                if (length == "area")
                                {
                                    Console.WriteLine("Enter the length of the square's side");
                                    int side1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The area of the square: {side1 * side1}");
                                }
                                else if (length == "perimeter")
                                {
                                    Console.WriteLine("Enter the length of the square's side");
                                    int side2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The perimeter of the square: {side2 * 4}");
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid input.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("You chose a circle. Area/Perimeter?");
                                string daire = Console.ReadLine().ToLower().Trim();
                                if (daire == "area")
                                {
                                    Console.WriteLine("Enter the radius of the circle");
                                    int kenar3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Area of the circle: {Math.PI * kenar3 * kenar3}");
                                }
                                else if (daire == "perimeter")
                                {
                                    Console.WriteLine("Enter the radius of the circle");
                                    int dairec = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Circumference of the circle: {Math.PI * 2 * dairec}");
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid input.");
                                }
                                break;

                            default:
                                Console.WriteLine("You typed wrong.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("You typed wrong.");
                        break;
                        #endregion
                }
            }
        }
    }


}
    

//Bu bir açıklama satırıdır.
//Namespace:İçinde classları bulunduran yapılardır.
//{} Scope(Blok) yapılarıdır
//Class:İçinde metodları bulunduran yapılardır.(Bu tanım şimdilik yaptığımız bir tanımdır, ilerleyen konularda bu konu detaylandıracağız)
//Metod: İş yapan kod bloklarına metod denir.
//Main metodu: Console uygulamalarının giriş noktasıdır. Her console uygulaması, main metodu ile başlar.
//Ctrl+F5: Hata ayıklama modu olmadan programı çalıştırır.
//Syntax: Programlama dilleri yazım kuralları

//C# Syntax: 
//1- Açılan parantezler mutlaka kapatılmalıdır.
//2- Scope tanımlamalarının sonunda ; bulunmaz.
//3- Satırların sonunda ; bulunur.
//4- Metodların sonunda mutlaka () bulunur.

//Syntax hatası olursa, program derlenmez. Dolayısıyla çalışmaz. VS hata olan yerin altını kırmızı çizgi ile işaretler. Bununla birlikte, scroolbarda'da kırmızı bir işaretle hatanın yerini bildirir.
//VS penceresinin altı kısmında da kırmızı bir çarpı işareti, yanında da kaç hata mesajı oldugu yazılır.

//IntelliSense: Kod yazarken yardımcı olan, açılan pencere.
//IntelliCode: Yapay Zeka destekli kod yazım yardımcısı.

//Solution Explorer: Solution'ınımız içindeki projelere ulaşabileceğimiz penceredir. View menusu aracılığı ile açılabilir.

//Solution: Bir yada birden fazla proje içerebilirler.

//Ctrl+K+C : Açıklama satırı
//Ctrl+K+U : Normal satıra geri dönüş
//Ctrl+K+D : Kod hiyerarşisini düzeltmek için kullanılır.

//C#->Derleme->MS-IL->Derleme(.NET Runtime)-> 0-1(Binary)

//MS-IL: Microsoft Intermediate Language
//1 bit = 0 veya 1
//8 bit = 1 byte
//1 Kilo Byte(KB) = 1024byte
//1 Mega Byte (MB) = 1024KB
//1 Giga Byte (GB) = 1024MB
//1 Tera Byte (TB) = 1024GB

//Değer tipleri belleğin STACK bölgesinde saklanır. Örn: int,double,float,bool...

//string veri tipi referans tipidir.Referans tipi veriler belleğin HEAP bölgesinde saklanır. Referans tipi verilerin referansları STACK bölgesinde saklanırken, değerleri HEAP bölgesinde saklanır.

//Referans tiplerinde aynı anda 1'den fazla değer saklanır. Bu nedenle daha büyük bellek bölgesine ihtiytaç duyar ve HEAP bölgesinde değerler saklanır.

//Referanslar, HEAP bölgesinde değerlerin adreslerini tutan yapılardır. Değerin kendisini tutmazlar

//Metodların işlerini yapabilmek için aldığı verilere METOD PARAMETRESİ denir.Bir metod gerekirse farklı tiplerde parametreler de alabilir.

//ReadLine(): Console sınıfında bulunan ve satır okuma işlemi yapan bir metoddur. Bu metod çalışmak için parametre istemez ancak okuduğu değeri string tipinde geri döndürür.

//void Metodlar: İşlem yaptıktan sonra geri dönüş yapmayan metodlardır.