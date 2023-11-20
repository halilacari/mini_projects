namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                bool uygulamadanCikisYapildi = false;
                bool dogruIslemGirisiYapildi = false;
                int islem = 0;

                while (true)
                {
                    while (!dogruIslemGirisiYapildi)
                    {


                        do
                        {
                            try
                            {
                                Console.WriteLine("\nHESAP MAKİNESİ UYGULAMASI");

                                Console.WriteLine("--------------------------");

                                Console.WriteLine("MENÜ\n");
                                Console.WriteLine("1-Toplama işlemi yap");
                                Console.WriteLine("2-Çıkarma işlemi yap");
                                Console.WriteLine("3-Çarpma işlemi yap");
                                Console.WriteLine("4-Bölme işlemi yap.");
                                Console.WriteLine("0-Çıkış yapın.\n\n");

                                Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");

                                islem = Convert.ToSByte(Console.ReadLine());

                                for (int i = 0; i < 5; i++)
                                {
                                    if (islem == i)
                                    {                                                           //GİRİLEN İŞLEMİN DOĞRUUĞUNU KONTROL ETMEK İÇİN YAZILDI...
                                        dogruIslemGirisiYapildi = true;
                                        Console.Clear();
                                    }

                                }

                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Yanlış işlem seçtiniz. Tekrar Deneyiniz.");

                            }                                      // bir sayi girildiğinde 0 ve 5 aralığında olup olmadığını kontrol eder...
                            if (islem > 4 || islem < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Yanlış işlem seçtiniz. Tekrar Deneyiniz.");
                            }
                        }
                        while (!dogruIslemGirisiYapildi);
                    }


                    if (islem == 0) { break; }                      // UYGULAMADAN ÇIKIŞ YAPMAK İÇİN YAZILDI.




                    decimal sayi1 = 0M;
                    decimal sayi2 = 0M;
                    bool dogruSayiGirisiYapildi = false;

                    if (islem == 1) Console.WriteLine("Toplama İslemi\n-----------");
                    if (islem == 2) Console.WriteLine("Çıkarma İslemi\n-----------");
                    if (islem == 3) Console.WriteLine("Çarpma İslemi\n-----------");
                    if (islem == 4) Console.WriteLine("Bölme İslemi\n-----------");

                    do
                    {
                        try
                        {
                            Console.WriteLine("Birinci sayiyi giriniz...");
                            sayi1 = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("İkinci sayiyi giriniz...");
                            sayi2 = Convert.ToDecimal(Console.ReadLine());                  //SAYILARIN DOĞRU GİRİLİP GİRİLMEDİĞİNİ KONTROL ETMEK İÇİN YAZILDI.
                            dogruSayiGirisiYapildi = true;

                            // bolme isleminde 2.sayi 0 olunca çalışacak hata kontrolü.
                            if (islem == 4 && sayi2 == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("sayi2 bölme işleminde sifir olamaz... Doğru değer giriniz...");
                                dogruSayiGirisiYapildi = false;
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            dogruSayiGirisiYapildi = false;
                            Console.WriteLine("Sayı yanlış girildi. Lütfen Tekrar Deneyiniz.");
                        }
                    }
                    while (!dogruSayiGirisiYapildi);





                    decimal sonuc;

                    bool bolmedeSifirKontrol = false;


                    switch (islem)
                    {
                        case 1:
                            sonuc = sayi1 + sayi2;

                            Console.WriteLine("Girilen sayilarin sonucu= " + sonuc);
                            Console.WriteLine("Lütfen Devam etmek için bir tuşa basın...");
                            bolmedeSifirKontrol = true;
                            Console.ReadKey();
                            break;
                        case 2:
                            sonuc = sayi1 - sayi2;

                            Console.WriteLine("Girilen sayilarin sonucu= " + sonuc);
                            Console.WriteLine("Lütfen Devam etmek için bir tuşa basın...");
                            bolmedeSifirKontrol = true;
                            Console.ReadKey();
                            break;
                        case 3:
                            sonuc = sayi1 * sayi2;

                            Console.WriteLine("Girilen sayilarin sonucu= " + sonuc);
                            Console.WriteLine("Lütfen Devam etmek için bir tuşa basın...");
                            bolmedeSifirKontrol = true;
                            Console.ReadKey();
                            break;
                        case 4:
                            sonuc = sayi1 / sayi2;

                            if (sayi2 == 0)
                            {
                                bolmedeSifirKontrol = false;

                                break;
                            }

                            Console.WriteLine("Girilen sayilarin sonucu= " + sonuc);
                            Console.WriteLine("Lütfen Devam etmek için bir tuşa basın...");
                            Console.ReadKey();
                            break;
                    }


                    {
                        dogruIslemGirisiYapildi = false;            //RESTART DURUMUNA GETİRMEK İÇİN YAZILDI...
                        dogruSayiGirisiYapildi = false;
                        Console.Clear();

                    }
                }


                Environment.Exit(0);
            }
        }

    }
