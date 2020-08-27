/*
 * Abbas 
 * ITSE 1430
 */
using System;

namespace HelloWorld
{
    // Pascal casing - Capitalize on wod boundaries including first word
    // Camel casing - Capitalize on word boundaries except first (e.g. firstName, payRate)
    class Program
    {
        // Function declaration - declaration to compiler that a function exists with a given signature
        //Function signature = function name and the parameter types (sometimes it will include return type)
        // Function definition - declaration + implementation
        static void Main(string[] args) // 1 parameter
        {
            // a single line comment
            // Another line of comments

            //Display given string to output
            //Arguments - data passed to function
            Console.WriteLine("Hello World!"); // printf, cout

            //Variable declaration:
            // T id;
            //int hours;
            //hours = 10; //Assignment operator: id = E;

            //Identifier Rules
            // 1. Unique within scope
            // 2. Must start with underscore or letter
            // 3. Consist of letters, digits, and underscores
            // ex.
            //  Valid? firstname - yes
            //  pay1Rate - yes
            //  1chance - no

            //Always camel case local variables
            //Preferred: T id = E;
            int hours = 10;

            //int pay = 0;
            //pay = hours * 9;
            int totalPay = hours * 9;

            //function overloading - multiple functions with same name but different parameters
            // atof - converts string to double
            // atoi - converts string to integer
            // c did not start off with function overloading so it had to make different named functions for similar functionality
            Console.WriteLine(totalPay);

        }
    }
}
