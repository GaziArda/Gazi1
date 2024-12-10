
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
    
