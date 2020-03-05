using System;

namespace cSharp_polymorphism
{
    class Program
    {
    
    void polyPrint(int myInteger)
    {
        Console.WriteLine("My integer is : {0}", myInteger);
    }

    void polyPrint(double myDouble) 
    {
        Console.WriteLine("My double is: {0}", myDouble);
    }
    void polyPrint(string myString)
    {
        Console.WriteLine("My string is: {0}", myString);
    }

    void withdraw(int bankBalance, int wihdrawlAmount)
    {
        Console.WriteLine(bankBalance -= wihdrawlAmount);
        Console.WriteLine("My new balance is: {0}", bankBalance);
    }
        static void Main(string[] args)
        {
            Program myPoly = new Program();

            myPoly.polyPrint(5000);
            myPoly.polyPrint("Hello World");
            myPoly.polyPrint(44.50);
            // Console.ReadKey();
            // Console.WriteLine("Hello World!");

            // int bankBalance = 500;
            // int wihdrawlAmount = 100;
            myPoly.withdraw(500, 30);

        }
    }
}
