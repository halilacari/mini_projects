namespace Solution6
{
    internal class program
    {
        static void Main(string[] args)
        {
            int outputInteger = 0;
            decimal outputDecimal = 0;

            Topla(2, 3, out outputInteger);
            Console.WriteLine(outputInteger);

            Topla(2000000, 300000, 400000000000000000, out outputDecimal);
            Console.WriteLine(outputDecimal);


            static void Topla(decimal number1, decimal number2, decimal number3, out decimal sonuc) 
            {
                sonuc = number1 + number2 + number3;


            }

            static void Topla(int number1, int number2, out int sonuc) 
            {
                sonuc = number1 + number2;

            }
        }
    }
}