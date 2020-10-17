/*
 * Abbas Ally
 * ITSE 1430
 * Lab 1
 */

using System;
using System.Globalization;

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

            DisplayMenu(accountName, accountNumber, startingBalance);
            
        }

        private static void DisplayMenu ( string accountName, string accountNumber, decimal currentBalance )
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Account Name:\t\t{accountName}");
                Console.WriteLine($"Account Number\t\t{accountNumber}");
                Console.WriteLine($"Current Balance:\t{currentBalance.ToString("C")}\n");
                Console.WriteLine("Choose a menu option: ");
                Console.WriteLine("1) Add Income");
                Console.WriteLine("2) Add Expense");
                Console.WriteLine("3) Quit");
                string value = Console.ReadLine();
                int menuOption;
                if (Int32.TryParse(value, out menuOption))
                {
                    switch (menuOption)
                    {
                        case 1:
                        {
                            Console.WriteLine("ADD INCOME");
                            decimal income = GetAmount();
                            currentBalance += income;
                            DisplaySuccess($"Income of {income.ToString("C")} successfully added");
                            break;
                        }                           
                        case 2:
                        {
                            Console.WriteLine("ADD EXPENSE");
                            decimal expense = GetAmount();
                            if (expense > currentBalance)
                            {
                                DisplayError("Expense denied. Insufficient Funds");
                            }
                            else
                            {
                                currentBalance -= expense;
                                DisplaySuccess($"Expense of {expense.ToString("C")} successfully deducted");
                            }                            
                            break;
                        }                            
                        case 3:
                        {
                            bool quit = DisplayQuit();
                            if (quit)
                                return;
                            break;
                        }                            
                        default:
                        {
                            DisplayError("Please enter a valid menu option");
                            break;
                        }                            
                    }
                }
                else
                {
                    DisplayError("Please enter a number corresponding to a menu option");
                }
            } while (true);
        }

        private static decimal GetAmount ()
        {
            Console.WriteLine("Amount: ");
            decimal amount = ReadDecimal(0.0M);
            Console.WriteLine("Description: ");
            string description = ReadString(true);
            Console.WriteLine("Category: ");
            string category = ReadString(false);
            Console.WriteLine("Entry Date: ");
            DateTime date = ReadDateTime();

            return amount;
        }

        private static bool DisplayQuit ()
        {
            Console.WriteLine("Are you sure you want to quit? (Y/N): ");
            do
            {
                string response = ReadString(true);
                if (String.Compare(response, "Y", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return true;
                else if (String.Compare(response, "N", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return false;
                else
                    DisplayError("Please respond with Y or N");
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
            Console.Write(message);
            Console.ResetColor();
            Console.Write("\n");
        }

        private static void DisplaySuccess ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
            Console.Write("\n");
        }

        private static string ReadString ( bool required )
        {
            while (true)
            {
                string value = Console.ReadLine();

                if (!required || !String.IsNullOrEmpty(value))
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
                        DisplayError($"Starting balance must be at least {minValue}");
                }
                DisplayError("Starting balance must be a monetary value");
            } while (true);
        }

        private static DateTime ReadDateTime ()
        {
            do
            {
                string value = Console.ReadLine();

                if (String.IsNullOrEmpty(value))
                    return DateTime.Now;

                DateTime result;
                if (DateTime.TryParseExact(value, "MM/dd/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out result ))
                    return result;

                DisplayError("Please enter a date in the MM/dd/yyyy format");
            } while (true);

        }
    }
}
