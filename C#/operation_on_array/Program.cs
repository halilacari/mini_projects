using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How many numbers will be in the array?: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");

        int[] numbers = new int[input];

        for (int i = 1; i <= input; i++)
        {
            Console.Write("Enter {0}.number: ", i);
            numbers[i - 1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
        }

        Console.WriteLine("Your numbers total is : {0}",sum(numbers));
    }

    private static int sum(int[] numbers)
    {
        int total = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        return total;
    }


}