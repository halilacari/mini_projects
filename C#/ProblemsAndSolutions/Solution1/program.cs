namespace Solution1
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç sayý gireceksiniz?");
            int numberCounter = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int evencounter = 0;
            int oddcounter = 0;
            int[] evenArray = { };
            int[] oddArray = { };

            for (int i = 0; i < numberCounter; i++)
            {
                Console.WriteLine((i + 1) + ". sayýyý giriniz..."); int number = Convert.ToInt32(Console.ReadLine());


                Console.Clear();

                if (number % 2 == 0)
                {
                    Array.Resize(ref evenArray, evencounter + 1);
                    evenArray[evencounter] = number;
                    evencounter++;

                }
                else
                {
                    Array.Resize(ref oddArray, oddcounter + 1);
                    oddArray[oddcounter] = number;
                    oddcounter++;

                }
            }
        }
    }
}