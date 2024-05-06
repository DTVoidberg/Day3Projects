
class CollatzConjecture
{

    public static void Main(string[] args)
    {
        int userNumber;
        Console.WriteLine("Welcome to the Collatz Conjecture \nPlease provide a number: ");
        userNumber = int.Parse(Console.ReadLine()!);
        Collatz(userNumber);

        Console.WriteLine(Collatz(userNumber));

    }
    private static int Collatz(int v)
    {
        if (v == 1)
        {
            return v;
        }
        if (v % 2 == 0)
        {
            return Collatz(v / 2);
        }
        else
            return Collatz(v *3 + 1);

    }
}