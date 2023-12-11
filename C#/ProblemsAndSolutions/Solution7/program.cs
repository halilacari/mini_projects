namespace Solution7
{
    internal class program
    {
        static void Main(string[] args)
        {
            bool inputIsTrue = true;
            int input;
            char exit;
            ArrayList divided2 = new ArrayList();
            ArrayList divided3 = new ArrayList();
            ArrayList notDivided = new ArrayList();
            do
            {
                Console.WriteLine("Bir sayý giriniz. Eðer sayý giriþiniz biterse, sayý haricinde rastgele bir tuþa basýnýz.");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input % 2 == 0)
                    {
                        divided2.Add(input);
                    }

                    if ((input % 3) == 0)
                    {
                        divided3.Add(input);
                    }

                    if ((input % 2) == 0 && (input % 3) == 0 && (input % 7) != 0)
                    {
                        notDivided.Add(input);
                    }

                }
                catch
                {
                    Console.WriteLine("Ýþleminizi bitirmek istiyorsanýz 'ESC' tuþuna basýnýz.Devam etmek istiyorsanýz enter tuþuna basýnýz.");

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        inputIsTrue = false;
                        Console.WriteLine("Çýkýþ Yapýldý...");
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    { Console.WriteLine("Ýþleme devam ediliyor..."); }
                    else Console.WriteLine("Lütfen tekrar deneyiniz...");
                }

            }
            while (inputIsTrue);

            Console.WriteLine("Ýkiye bölünenler: ");
            foreach (int i in divided2)
            {
                Console.Write(i + ",");

            }
            Console.WriteLine();
            Console.WriteLine("Üçe bölünenler: ");
            foreach (int i in divided3)
            {
                Console.Write(i + ",");

            }
            Console.WriteLine();
            Console.Write("Ýki ve üçe bölünüp yediye bölünmeyenler: ");
            foreach (int i in notDivided)
            {
                Console.Write(i + ",");
            }
        }
    }
}