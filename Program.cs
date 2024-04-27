using System;
using EventsSolution;

class Program
{
    static void Main(string[] args)
    {
        PiggyBank pb = new PiggyBank();

        pb.BalanceChanged += (amount) => Console.WriteLine($"The balance amount is {amount}");
        pb.BalanceChanged += (amount) =>
        {
            if (amount > 500.0m)
                Console.WriteLine($"You reached your saving goal! You have U$ {amount}");
        };

        string theStr;
        do
        {
            Console.WriteLine("How much would you like to deposit?");
            theStr = Console.ReadLine();
            if (!theStr.Equals("exit"))
            {
                // Converting to decimal
                decimal newVal = decimal.Parse(theStr);

                pb.theBalance += newVal;
            }

        } while (!theStr.Equals("exit"));
    }
}