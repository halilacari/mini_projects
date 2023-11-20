namespace TrafficLights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool degerGirildi = false;
            Console.WriteLine("KIRMIZI ,SARI ,YEŞİL olmak üzere 3 değerden birini giriniz. ");



            while (degerGirildi == false)
            {
                string deger = Console.ReadLine().ToLower();
                Console.Clear();


                switch (deger)
                {
                    case "kırmızı":
                        {
                            Console.WriteLine("!!!LÜTFEN BEKLEYİN...!!!");
                            degerGirildi = true;
                            break;
                        }

                    case "sarı":
                        {
                            Console.WriteLine("!!!HAZIRLANIN!!!");
                            degerGirildi = true;
                            break;
                        }

                    case "yeşil":
                        {
                            Console.WriteLine("!!!GEÇİN!!!");
                            degerGirildi = true;
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Hatali bir seçim yaptnız. Tekrar Deneyiniz. \n");

                            Console.WriteLine("KIRMIZI ,SARI ,YEŞİL olmak üzere 3 değerden birini giriniz. ");

                            break;
                        }



                }

            }
        }
    }

}
