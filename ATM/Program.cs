using System;
using System.IO.Pipes;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var person = ("Tsoler Hayitian", "12345671-1234");
            var account = new BankAccount();
            var customer = new Customer_klass(person.Item1, decimal.Parse(person.Item2.Replace("-", "")), account);


            Console.WriteLine($"Welcome {customer.Name} to your ATM Bank Account!");

            // Login with PIN
            int tries = 0;
            const int maxTries = 3;
            bool loggedIn = false;


            while (tries < maxTries && !loggedIn)
            {
                Console.Write("Enter 4-digit PIN: ");
                string pin = Console.ReadLine();


                if (pin == "1234")

                {
                    loggedIn = true;
                }
                else
                {
                    tries++;
                    Console.WriteLine($"Wrong PIN. Try again {tries}/{maxTries}.");
                    const string PIN = "1234";

                }
            }


            if (!loggedIn)
            {
                Console.WriteLine("Login failed. Program closing.");
                return;
            }

            // Menu loop
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Show balance");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            account.Deposit(depositAmount);
                            Console.WriteLine($"Deposited {depositAmount:C}. New balance: {account.Balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "2":
                        Console.Write("Enter amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            if (account.Withdraw(withdrawAmount))
                            {
                                Console.WriteLine($"Withdrew {withdrawAmount:C}. New balance: {account.Balance:C}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "3":
                        Console.WriteLine($"Current balance: {account.Balance:C}");
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
        }
    }
}
