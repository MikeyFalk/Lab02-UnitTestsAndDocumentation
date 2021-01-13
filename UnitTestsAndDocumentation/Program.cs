using System;

namespace UnitTestsAndDocumentation
{
    class Program
    {
        static public decimal Balance = 5000;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserInterface();
        }

        static int UserInterface()
        {
            Console.WriteLine("Hello, What would you like to do today?");
            Console.WriteLine("1. View Balance 2. Withdraw 3. Deposit 4.Exit");
         
            string userChoice = Console.ReadLine();

            string response = "";

            if (userChoice == "1")
                response = $"You have {balance}"
            else if (userChoice == "2")
                response = "How much would you like to withdraw?";
            else if (userChoice == "3")
                response = "How much would you like to deposit?";
            else if (userChoice == "4")
                response = "Thank you for stopping by";
            else response = "Please choose a valid response";
            Console.WriteLine(response);
        }
        static public decimal ViewBalance()
        {
            balance = "You have 5000?";
            Console.WriteLine(balance);
        }
        static decimal Withdraw()
        {

        }
        static decimal Deposit()
        {

        }

    }
}
