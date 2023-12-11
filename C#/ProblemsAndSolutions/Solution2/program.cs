namespace Solution2
{
    internal class program
    {
        static void Main(string[] args)
        {
            string[] wordArray = new string[5];
            string[] longestWords = { "" };
            int[] wordIndex = { 0 };




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ".kelimeyi girin.");
                wordArray[i] = Console.ReadLine();
                if (longestWords[0].Length < wordArray[i].Length)
                {
                    Array.Clear(longestWords);
                    Array.Clear(wordIndex);
                    Array.Resize(ref longestWords, 1);
                    Array.Resize(ref wordIndex, 1);
                    longestWords[0] = wordArray[i];
                    wordIndex[0] = i;
                }
                else if (longestWords[0].Length == wordArray[i].Length)
                {
                    Array.Resize(ref longestWords, longestWords.Length + 1);
                    longestWords[longestWords.Length - 1] = wordArray[i];

                    Array.Resize(ref wordIndex, wordIndex.Length + 1);
                    wordIndex[wordIndex.Length - 1] = i;

                }
            }

            if (longestWords.Length > 1)
            {
                Console.WriteLine("Dizide en büyük olup ayný uzunluða sahip " + longestWords.Length + " kelime vardýr.\n\n");
                for (int i = 0; i < longestWords.Length; i++)
                {
                    Console.WriteLine("Dizideki en uzun elemanlardan " + (i + 1) + ".si             = " + longestWords.GetValue(i));
                    Console.WriteLine("Dizideki en uzun elemanlardan " + (i + 1) + ".sinin uzunluðu = " + +longestWords[0].Length);
                    Console.WriteLine("En uzun elemanlardan " + (i + 1) + ".sinin indexi            = " + wordIndex[i] + "\n");

                }
            }
            else
            {
                Console.WriteLine("En uzun eleman            = " + longestWords[0]);
                Console.WriteLine("En uzun elemanýn uzunluðu = " + longestWords[0].Length);
                Console.WriteLine("En uzun elemanýn indexi   = " + wordIndex[0]);
            }
        }
    }
}