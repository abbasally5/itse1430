/*
 * ITSE 1430
 * Budget
 * Sample implementation
 * 
 * NOTE: This sample implementation limits the usage of C# features to those covered in section 1. The code given
 * here should not be construed as appropriate for future lab assignments.
 */
using System;

namespace SampleBudget
{
    class Program
    {
        static void Main ( )
        {
            GetAccountInformation();

            var done = false;
            do
            {
                switch (DisplayMenu())
                {
                    case MenuOption.Income: AddIncome(); break;
                    case MenuOption.Expense: AddExpense(); break;
                    case MenuOption.Quit: done = ConfirmQuit(); break;
                };
            } while (!done);
        }

        /// <summary>Removes money from an account.</summary>
        static void AddExpense ()
        {
            Console.Write("Enter expense amount: ");
            var amount = ReadDecimal(0.01M);

            Console.Write("Enter description: ");
            var description = ReadString(true);

            Console.Write("Enter category (optional): ");
            var category = ReadString(false);

            Console.Write("Enter entry date (press ENTER to use Today): ");
            var entryDate = ReadDate(false, DateTime.Today);

            accountBalance -= amount;

            Console.WriteLine($"Removed {amount:C} from account for '{description}' on {entryDate}");
        }

        /// <summary>Adds money to an account.</summary>
        static void AddIncome ()
        {
            Console.Write("Enter income amount: ");
            var amount = ReadDecimal(0.01M);

            Console.Write("Enter description: ");
            var description = ReadString(true);

            Console.Write("Enter category (optional): ");
            var category = ReadString(false);

            Console.Write("Enter entry date (press ENTER to use Today): ");
            var entryDate = ReadDate(false, DateTime.Now);

            accountBalance += amount;

            Console.WriteLine($"Added {amount:C} to account from '{description}' on {entryDate}");
        }

        /// <summary>Confirms the user wants to quit.</summary>
        /// <returns><see langword="true"/> to quit.</returns>
        static bool ConfirmQuit ()
        {
            Console.Write("Are you sure (Y/N)? ");

            return ReadBoolean('Y', 'N');
        }

        /// <summary>Displays the account information.</summary>
        static void DisplayAccountInformation ()
        {
            Console.WriteLine();
            Console.WriteLine($"Account: {accountName} ({accountNumber})");
            Console.WriteLine($"Balance: {accountBalance:C}");
        }

        /// <summary>Displays an error message.</summary>
        /// <param name="message">The message to display.</param>
        static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }

        /// <summary>Displays the main menu.</summary>
        /// <returns>The menu option.</returns>
        static MenuOption DisplayMenu ()
        {
            DisplayAccountInformation();

            Console.WriteLine("".PadLeft(80, '-'));
            Console.WriteLine("1) Add Income");
            Console.WriteLine("2) Add Expense");
            Console.WriteLine("".PadLeft(5, '-'));
            Console.WriteLine("0) Quit");
            Console.WriteLine("? ");
            do
            {
                var input = Console.ReadLine().Trim();
                switch (input)
                {
                    case "1": return MenuOption.Income;
                    case "2": return MenuOption.Expense;

                    case "0": return MenuOption.Quit;
                };

                DisplayError("Invalid option selected");
            } while (true);
        }

        /// <summary>Gets account information.</summary>
        static void GetAccountInformation ()
        {
            Console.Write("Enter account name: ");
            accountName = ReadString(true);

            accountNumber = ReadAccountNumber();

            Console.Write("Enter account balance: ");
            accountBalance = ReadDecimal(0.01M);
        }

        /// <summary>Determines if a string is a numeric string.</summary>
        /// <param name="input">The string.</param>
        /// <returns><see langword="true"/> if numeric string or <see langword="false"/> otherwise.</returns>
        static bool IsNumericString ( string input )
        {
            foreach (var ch in input)
                if (!Char.IsDigit(ch))
                    return false;

            return true;
        }

        /// <summary>Reads account number.</summary>
        /// <remarks>
        /// Account number must be all digits.
        /// </remarks>
        /// <returns>The account number.</returns>
        static string ReadAccountNumber ()
        {
            do
            {
                Console.Write("Enter account number (must be digits): ");

                var number = ReadString(true);
                if (IsNumericString(number))
                    return number;

                DisplayError("Account number must consist of only digits");
            } while(true);
        }

        /// <summary>Reads a boolean value.</summary>
        /// <param name="trueValue">The value to use for <see langword="true"/>.</param>
        /// <param name="falseValue">The value to use for <see langword="false"/>.</param>
        /// <returns>The boolean value.</returns>
        static bool ReadBoolean ( char trueValue, char falseValue )
        {
            do
            {                
                var key = Console.ReadKey(true);

                if (String.Compare(key.KeyChar.ToString(), trueValue.ToString(), true) == 0)
                    return true;
                else if (String.Compare(key.KeyChar.ToString(), falseValue.ToString(), true) == 0)
                    return false;
            } while (true);
        }

        /// <summary>Reads a date.</summary>
        /// <param name="isRequired"><see langword="true"/> if the value is required.</param>
        /// <param name="defaultValue">If the value is not required then the value to return when not provided.</param>
        /// <returns></returns>
        static DateTime ReadDate ( bool isRequired, DateTime defaultValue )
        {
            do
            {
                var input = ReadString(isRequired);
                if (!isRequired && String.IsNullOrEmpty(input))
                    return defaultValue;

                if (DateTime.TryParse(input, out var date))
                    return date;

                DisplayError("Enter a valid date");
            } while (true);
        }

        /// <summary>Reads a decimal value.</summary>
        /// <param name="minimumValue">The optional minimum value.</param>
        /// <returns>The decimal value.</returns>
        static decimal ReadDecimal ( decimal minimumValue )
        {
            do
            {
                var input = Console.ReadLine().Trim();

                if (Decimal.TryParse(input, out var result) && result >= minimumValue)
                    return result;

                if (minimumValue != Decimal.MinValue)
                    DisplayError($"Value must be at least {minimumValue}");
                else
                    DisplayError("Value must be a number");
            } while (true);
        }
   
        /// <summary>Reads a string value.</summary>
        /// <param name="isRequired"><see langword="false"/> to allow empty strings.</param>
        /// <returns>The value.</returns>
        static string ReadString ( bool isRequired )
        {
            do
            {
                var input = Console.ReadLine().Trim();

                if (!isRequired || !String.IsNullOrEmpty(input))
                    return input;

                DisplayError("Value is required");
            } while (true);
        }

        //Using static variables until chapter 2
        static string accountName;
        static string accountNumber;
        static decimal accountBalance;

        //Using an enumeration here to avoid magic constants
        enum MenuOption
        {
            Income,
            Expense,
            Quit
        }
    }
}
