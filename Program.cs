using System;
using EventsSolution;

class Program
{
    static void Main(string[] args)
    {
        PiggyBank pb = new PiggyBank();
        BalanceLogger bl = new BalanceLogger();
        BalanceWatcher bw = new BalanceWatcher();

        pb.BalanceChanged += bl.BalanceLog;
        pb.BalanceChanged += bw.BalanceWatch;

        string theStr;
        do
        {
            Console.WriteLine("How much would you like to deposit?");
            theStr = Console.ReadLine();
            if(!theStr.Equals("exit"))
            {
                // Converting to decimal
                decimal newVal = decimal.Parse(theStr);

                pb.theBalance += newVal;
            }
            
        } while (!theStr.Equals("exit"));
    }
}