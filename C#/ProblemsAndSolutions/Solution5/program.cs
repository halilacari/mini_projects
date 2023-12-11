namespace Solution5
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question5(1001m, 1002m, 1003m));

            static Decimal Question5(decimal no1, decimal no2, decimal no3)
            {
                decimal[] numbers = { no1, no2, no3 };
                decimal largestNumber = no1;

                foreach (decimal number in numbers)
                {
                    if (largestNumber < number)
                    {
                        largestNumber = number;
                    }
                }

                return largestNumber;
            }
        }
    }
}