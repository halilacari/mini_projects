namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random randomGen = new Random();

                int number_in_memory = randomGen.Next(0, 101);

                bool correct = false;

                int counter = 0;

                int advice = 0;



                while (!correct)
                {
                    Console.WriteLine("Enter your think: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    counter++;

                    if (number_in_memory == input)
                    {
                        Console.WriteLine("Your think is: {0} correct .You find in {1} try. Congrulations!!!", input, counter);

                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Your think is: {0} incorrect ", input);
                        hint(input, number_in_memory);
                    }

                }


            }

            static void hint(int input, int number_in_memory)
            {
                if (input > number_in_memory)
                {
                    Console.Write(" Number is lower than your think.Try Again!!!");
                }
                else
                {
                    Console.Write(" Number is bigger than your think.Try Again!!!");
                }
            }
        }
    }
}