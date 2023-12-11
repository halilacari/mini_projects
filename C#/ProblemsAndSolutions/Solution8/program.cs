namespace Solution7
{
    internal class program
    {
        static void Main(string[] args)
        {
            double[,] coordinats = new double[5, 2];

            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ". koordinatýn x eksenini giriniz."); coordinats[i, 0] = Convert.ToDouble(Console.ReadLine());
                Console.Write((i + 1) + ". koordinatýn y eksenini giriniz."); coordinats[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            int counter = 1;
            while (counter < 5)
            {
                for (int i = 1; i < counter; i++)
                {
                    Console.Write($"{counter}.nokta - {i}.nokta arasý uzaklýk:{Math.Sqrt(((coordinats[counter, 0] * coordinats[counter, 0]) - (coordinats[i, 1] * coordinats[i, 1])))}"); Console.Write("   ");
                }
                counter++;
                Console.WriteLine();
            }
        }
    }
}