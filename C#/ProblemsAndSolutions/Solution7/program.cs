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
                Console.WriteLine("Bir say� giriniz. E�er say� giri�iniz biterse, say� haricinde rastgele bir tu�a bas�n�z.");
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
                    Console.WriteLine("��leminizi bitirmek istiyorsan�z 'ESC' tu�una bas�n�z.Devam etmek istiyorsan�z enter tu�una bas�n�z.");

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        inputIsTrue = false;
                        Console.WriteLine("��k�� Yap�ld�...");
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    { Console.WriteLine("��leme devam ediliyor..."); }
                    else Console.WriteLine("L�tfen tekrar deneyiniz...");
                }

            }
            while (inputIsTrue);

            Console.WriteLine("�kiye b�l�nenler: ");
            foreach (int i in divided2)
            {
                Console.Write(i + ",");

            }
            Console.WriteLine();
            Console.WriteLine("��e b�l�nenler: ");
            foreach (int i in divided3)
            {
                Console.Write(i + ",");

            }
            Console.WriteLine();
            Console.Write("�ki ve ��e b�l�n�p yediye b�l�nmeyenler: ");
            foreach (int i in notDivided)
            {
                Console.Write(i + ",");
            }
        }
    }
}