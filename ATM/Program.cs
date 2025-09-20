namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---ATM MAIN MENU:---");
            Console.WriteLine("1. Deposit Money:");
            Console.WriteLine("2. Withdraw Money:");
            Console.WriteLine("3. Check Balance:");
            Console.WriteLine("4. Exit:");
            Console.WriteLine("---------------------");
            Console.WriteLine("Please select an option (1-4):");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    DepositMoney();
                    break;
                case "2":
                    WithdrawMoney();
                    break;
                case "3":
                    CheckBalance();
                    break;
                case "4":
                    continueRinning = false;
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
                 }
                        if (continueRunning)
                 {

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();


            }
            
        }
    }
}
