namespace Solution4
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir metin giriniz..."); string text = Console.ReadLine();
            Console.WriteLine("Girdi= " + text);
            text = text.ToLower();
            string[] textToArray = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                textToArray[i] = text[i].ToString();
            }

            Array.Sort(textToArray);

            ArrayList letters = new ArrayList();
            ArrayList numbers = new ArrayList();

            char[] textChar = new char[text.Length];

            for (int i = 0; i < textToArray.Length; i++)
            {
                int number;
                if (int.TryParse(textToArray[i], out number))
                {
                    numbers.Add(number);
                }
                else if (textToArray[i] != " ") letters.Add(textToArray[i]);
            }

            ArrayList printedLetters = new ArrayList();
            ArrayList printedNumbers = new ArrayList();


            Console.WriteLine("Harfler:");
            for (int i = 0; i < letters.Count; i++)
            {
                for (int j = 0; j < letters.Count; j++)
                {
                    if (!printedLetters.Contains(letters[i]))
                    {
                        Console.Write(letters[i]);
                        printedLetters.Add(letters[i]);

                        if (i != letters.Count - 1) Console.Write(",");
                        else Console.Write("\n");
                    }
                }

            }

            Console.WriteLine("Sayýlar:");
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (!printedNumbers.Contains(numbers[i]))
                    {
                        Console.Write(numbers[i]);
                        printedNumbers.Add(numbers[i]);

                        if (i != numbers.Count - 1) Console.Write(",");
                    }
                }

            }
        }
    }
}