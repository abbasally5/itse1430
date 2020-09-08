/*
 * Abbas Ally
 * ITSE 1430
 * Lab 1
 */

using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a budgeting program written by Abbas Ally");

            Console.WriteLine("Enter Account Name: ");
            string accountName = ReadString(true);
            Console.WriteLine("Enter Account Number: ");
            string accountNumber = GetAccountNumber();
            Console.WriteLine("Enter Starting Balance: ");
            decimal startingBalance = ReadDecimal(0.0M);

            DisplayMenu(startingBalance);
            
        }

        private static void DisplayMenu ( decimal currentBalance )
        {
            do
            {
                Console.WriteLine("\nCurrent Balance: " + currentBalance.ToString("C") + "\n");
                Console.WriteLine("Choose a menu option: ");
                Console.WriteLine("3) Quit");
                string value = Console.ReadLine();
                int menuOption;
                if (Int32.TryParse(value, out menuOption))
                {
                    switch (menuOption)
                    {
                        case 3:
                            bool quit = DisplayQuit();
                            if (quit)
                                return;
                            break;
                        default:
                            DisplayError("Please enter a valid menu option");
                            break;
                    }
                }
                else
                {
                    DisplayError("Please enter a number corresponding to a menu option");
                }
            } while (true);
        }

        private static bool DisplayQuit ()
        {
            Console.WriteLine("Are you sure you want to quit? (Y/N): ");
            do
            {
                string response = ReadString(true);
                switch (response.ToUpper())
                {
                    case "Y": return true;
                    case "N": return false;
                    default: DisplayError("Please respond with Y or N"); break;
                }
            } while (true);            
        }

        private static string GetAccountNumber ()
        {
            string numberValidation = "0123456789";
            
            do
            {
                string accountNumber = ReadString(true);
                bool isNumber = false;
                foreach (char c in accountNumber)
                {
                    isNumber = false;
                    foreach (char number in numberValidation)
                    {                        
                        if (c == number)
                        {
                            isNumber = true;
                            break;
                        }
                    }
                    if (!isNumber)
                        break;
                }
                if (!isNumber)
                    DisplayError("Account Number must be a series of numbers");
                else 
                    return accountNumber;

            } while (true);
        }

        private static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine(message);

            Console.ResetColor();
        }

        private static string ReadString ( bool required )
        {
            while (true)
            {
                string value = Console.ReadLine();

                if (!required || value != "")
                {
                    return value;
                }

                DisplayError("Value is required");
            }
        }

        private static decimal ReadDecimal ( decimal minValue )
        {
            do
            {
                string value = Console.ReadLine();

                decimal result;
                if (Decimal.TryParse(value, out result))
                {
                    if (result >= minValue)
                        return result;
                    else
                        DisplayError("Starting balance must be at least " + minValue);
                }
                DisplayError("Starting balance must be a monetary value");
            } while (true);
        }

        //private static int ReadInt ( int minValue )
        //{
        //    do
        //    {

        //    }
        //}
    }
}
