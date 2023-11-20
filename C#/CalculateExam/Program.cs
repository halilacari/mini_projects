namespace ExamResultCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sayiGirildi = false;
            double sonuc = 0;

            int sinav1 = 0;
            int sinav2 = 0;
            int sinav3 = 0;


            while (!sayiGirildi)
            {

                do
                {
                    sayiGirildi = true;
                    try
                    {
                        Console.WriteLine("1. Sınav sonucunuzu giriniz...");
                        sinav1 = int.Parse(Console.ReadLine());
                        if (sinav1 < 0 || sinav1 > 100)
                        {
                            sayiGirildi = false;
                            Console.Clear();
                            Console.WriteLine("Sınav sonucunuzu 0 ile 100 arasında giriniz. Lütfen Tekrar Deneyiniz.");
                            break;

                        }


                        Console.WriteLine("\n2. Sınav sonucunuzu giriniz...");
                        sinav2 = int.Parse(Console.ReadLine());
                        if (sinav2 < 0 || sinav2 > 100)
                        {
                            sayiGirildi = false;
                            Console.Clear();
                            Console.WriteLine("Sınav sonucunuzu 0 ile 100 arasında giriniz. Lütfen Tekrar Deneyiniz.");
                            break;
                        }


                        Console.WriteLine("\n3. Sınav sonucunuzu giriniz...");
                        sinav3 = int.Parse(Console.ReadLine());
                        if (sinav3 < 0 || sinav3 > 100)
                        {
                            sayiGirildi = false;
                            Console.Clear();
                            Console.WriteLine("Sınav sonucunuzu 0 ile 100 arasında giriniz. Lütfen Tekrar Deneyiniz.");
                            break;
                        }

                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        sayiGirildi = false;
                        Console.WriteLine("Sınav sonucu yanlış girildi. Lütfen Tekrar Deneyiniz.");
                    }
                }
                while (sayiGirildi == false);

            }
            Console.Clear();

            sonuc = ((sinav1 + sinav2 + sinav3) / 3.0);


            if (sonuc < 45) { Console.WriteLine("NOTUNUZ : FF"); }

            else if (sonuc >= 45 && sonuc < 65) { Console.WriteLine("NOTUNUZ : DD"); }

            else if (sonuc >= 65 && sonuc < 75) { Console.WriteLine("NOTUNUZ : CC"); }

            else if (sonuc >= 75 && sonuc < 85) { Console.WriteLine("NOTUNUZ : BB"); }

            else { Console.WriteLine("NOTUNUZ : AA "); }

        }

            }
        }
    }

}
