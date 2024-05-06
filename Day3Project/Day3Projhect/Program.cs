using System;
using System.Linq;
using System.Net.Http.Headers;

public static class Day3CeasarCiphers
{
    public static void Main(string[] args)
    {

        var retry = true;

        while (retry)
        {

            Console.WriteLine("Ceasar Cipher \nHow many characters would you like?: ");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userNumber))
            {
                Console.WriteLine(RandomString(userNumber));
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Do you want to try again? y or n");
            string? userReply = Console.ReadLine();
            if (userReply != "y")
                retry = false;

        }
    }
    private static Random random = new Random();

    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}