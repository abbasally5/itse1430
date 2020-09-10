using System;

namespace MovieLibrary
{
    class Program
    {
        static void Main ( string[] args )
        {
            //FunWithTypes();
            //FunWithVariables();

            // while => while (E) S
            // 0+ iterations, pre test condition
            while (true)
            {
                //Scope - lifetime of a variable : starts at declaration and continues until end of current scope
                //char choice = DisplayMenu();
                //if (choice == 'Q')
                //    return;
                //else if (choice == 'A')
                //    AddMovie();
                switch (DisplayMenu())
                {
                    case 'Q': return;

                    case 'A': AddMovie(); break;

                    case 'V': ViewMovie(); break;
                }
            };
        }

        static string title = "";
        static string description = "";
        static string rating = "";
        static int duration;
        static bool isClassic;

        static void AddMovie ()
        {
            // Get title
            Console.WriteLine("Movie title: ");

            // Type inferencing
            // Restrictions:
            // 1. ONLY works with local variables
            // 2. Variable must be initialized
            // 3. (Sort of ) Cannot figure out type or it is wrong
            //string title = ReadString(true);
            title = ReadString(true); // identical to string title = ReadString(true);

            //Get description
            Console.WriteLine("Description (optional): ");
            description = ReadString(false);

            // Get rating
            Console.WriteLine("Rating: ");
            rating = ReadString(false);

            // Get duration
            Console.WriteLine("Duration (in minutes): ");
            duration = ReadInt32(0);

            //Get is classic
            Console.WriteLine("Is Classic (Y/N) ");
            //string isClassic = Console.ReadLine();
            isClassic = ReadBoolean();
        }

        static char DisplayMenu ()
        {
            // 1+ iteration, post test
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Movie Library");
                Console.WriteLine("-------------");

                Console.WriteLine("A)dd Movie");
                Console.WriteLine("V)iew Movie");
                Console.WriteLine("Q)uit");

                //Get input from user
                string value = Console.ReadLine();

                //C++: if (x = 10) ; // Not valid in C#
                // if (E) S;
                // if (E) S else S;
                if (value == "Q") // 2 equal signs => equality
                    return 'Q';
                else if (value == "A")
                    return 'A';
                else if (value == "V")
                    return 'V';

                DisplayError("Invalid option");
            } while (true);
        }

        private static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }

        static bool ReadBoolean ()
        {
            do
            {
                // Read as string
                string value = Console.ReadLine();

                // Not useful because of how it is parsed
                //Boolean.TryParse(value, out bool result)

                // switch - replacement for if-else-if WHEN
                // EACH condition is against the same variable
                // AND equality
                // switch (E)
                // {
                //      case*
                //      [default]
                // }
                // case ::= case E : S*
                // default ::= default : S*
                //if (value == "Y" || value == "y") // NOT THE SAME ::= value == "Y" || "y"
                //    return true;
                //else if (value == "N" || value == "n")
                //    return false;
                // else
                //      S;
                // C++ DIFFERENCES
                //  1. No fallthrough - case E: S; case E2 : S;
                //  2. Any expression type is allowed (for the most part)
                //  3. Case labels must be unique an compile time constants
                //  4. Multiple statements are allowed in body of case 
                switch (value)
                {
                    case "X": Console.WriteLine("Wrong value"); break; // break is required

                    case "Y":               // If case statement is empty (includign semicolon) then fallthrough
                    case "y": return true;

                    case "N": 
                    case "n": return false;

                    case "A":
                    {
                        // Use block statement for more than 1 statement
                        Console.WriteLine("wrong value");
                        Console.WriteLine("wrong value again");
                        break;
                    }
                        

                    default: break;// if nothing else
                }

                DisplayError("Invalid option");
            } while (true);
        }

        static int ReadInt32 ()
        {
            return ReadInt32(Int32.MinValue);
        }
        static int ReadInt32 ( int minimumValue )
        {
            do
            {
                string value = Console.ReadLine();

                // Parse to int int Int32.Parse( string )
                //int result = Int32.Parse(value);
                
                // Parameter kinds
                // Input parameter ("pass by value") - a copy of the argument is placed into parameter inside function definition
                // Input/output parameter ("pass by reference") = a reference to the argument is passed to the function and both original argument and parameter reference same value ( C++: int& )
                // Output parameter - function caller does not provide input, function always provides output (C++: return type)
                //bool Int32.TryParse ( string, out int result 
                // Double.Parse/TryParse
                // Single.Parse/TryParse
                // Int16.Parse/TryParse
                // All primitive types have parse/tryparse functions
                
                // Inline variable declaration - out parameters only
                //int result;
                //if (Int32.TryParse(value, out int result) && result >= minimumValue)
                if (Int32.TryParse(value, out var result) && result >= minimumValue)
                    return result;
                
                // break; // Terminates the loop
                // continue; // Terminates the iteration

                if (minimumValue != Int32.MinValue) //Int32.MaxValue
                    DisplayError("Value must be at least " + minimumValue); //String concatenation
                else
                    DisplayError("Must be integral value");
            } while (true);
        }

        static void ViewMovie ()
        {
            Console.WriteLine(title);

            // TODO: Description if available
            Console.WriteLine(" " + description);

            // TODO: Rating if available
            Console.WriteLine(" " + rating);

            Console.WriteLine(duration);

            Console.WriteLine(isClassic);
        }

        // Arithmetic (unary)
        // +E
        // -E

        // Arithmetic (binary) - type coercion
        // addition 10 = 12
        // subtraction 123 - 110.4
        // multiplication 10 * 28
        // division 30 / 3
        // modulus 7 % 4 => 3 (remainder), only works with integrals

        // integer division problem
        // 10 / 3 => int / int => int = 3
        // 10.0 / 3 => double / int => double = 3.33
        // (double) / 3 => double / int

        // typecase => (T)E
        // not allowed => (string)10 , (int)"Hello", (int)10.5

        // Logical operators (work on booleans, return booleans)
        // NOT => !E : boolean
        // AND => E && E : boolean
        // OR => E || E : boolean

        // Relational operators (primitives + a few extras)
        // equality => E == E
        // inequality => E != E
        // greater than => E > E
        // greater than or equal to => E >= E
        // less than => E < E
        // less than or equal to => E <= E
        static string ReadString ( bool required )
        {
            do
            {
                string value = Console.ReadLine();

                // If not required or not empty return
                if (!required || value != "")
                    return value;

                DisplayError("Value is required");
            } while (true);
            
        }

        #region Demoing Language Features
        
        static void FunWithSttings ()
        {
            // 5 characters in it, takes up 10 bytes
            // C++ difference: no NULL
            // Escape sequence begins with \ and is followed by generally 1 character, only works in literals
            // escape sequences count as 1 character (new line counts as 2)
            //      \n - newline
            //      \t - tab
            //      \" - " double quote
            //      \' - ' single quote (char literal)
            //      \\ - \
            //      \xHH - hex equivalent \x0A
            var name = "Bob\c"; // Compiler warning if using unknown escape sequence
            var message = "Hello \"Bob\"\nWorld";

            // File paths - always have excape sequences
            var filePath = "C:\\Temp\\test.pdf"; // C:\Temp\test.pdf
            var filePath = @"C:\Temp\test.pdf"; // Verbatim string - compiler ignores \ as escape sequence

            // TODO: null and empty string
        } 
    }
}
