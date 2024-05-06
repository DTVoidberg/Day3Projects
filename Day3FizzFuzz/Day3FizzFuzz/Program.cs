class FizzBuzz
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FizzBuzz \nPlease enter a number: ");
        string? userInput = Console.ReadLine();
        int.TryParse(userInput, out int userNumber);

        for (int i = 1; i <= userNumber; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }



    }

}
