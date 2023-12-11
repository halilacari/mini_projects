.namespace Solution3
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime girin..."); string word = Console.ReadLine();

            for (int i = word.Length; i > 0; i--)
            {
                Console.Write(word[i - 1]);
            }
        }
    }
}