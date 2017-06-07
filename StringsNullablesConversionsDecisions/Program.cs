using System;
using System.Text;

namespace StringsNullablesConversionsDecisions
{
    class Program
    {
        static void Main()
        {
            // Use a StringBuilder to efficiently change an original string containing
            // the text "Cat" to a result that has one character changed to produce the
            // result "Rat". Then display that result in the console window.
            string originalString = "Cat";             // initialize String
            System.Console.WriteLine(originalString);          // output
            System.Text.StringBuilder sb =
                new System.Text.StringBuilder(originalString); // copy to StringBuilder
            sb[0] = 'R';                                       // efficiently manipulate in situ
            string resultingString = sb.ToString();            // get new string back out
            System.Console.WriteLine(resultingString);         // output

            // Declare a nullable int named x, initialize it to null, and then
            // display it in console output. Then display the boolean value that
            // indicates whether x has a value or not. After that, assign 42 to it
            // and display it again and then display the boolean value again that
            // indicates whether x has a value or not.
            int? x = null;
            
            if (x.HasValue)
            {
                int ex = x.Value;
                System.Console.WriteLine("x: " + x);
            }
            else
            {
                System.Console.WriteLine("x: null"); // executed
            }

            x = 42;
            if (x.HasValue)
            {
                decimal ex = x.Value;
                System.Console.WriteLine("x: " + ex); // executed
            }
            else
            {
                System.Console.WriteLine("x: null"); // not executed
            }

            System.Console.WriteLine(x);

            

            // Declare a DateTime variable named aDateTime, and assign it to the result of
            // converting the string "4 July 1776" to a DateTime object. Then display the result.
            System.DateTime aDateTime = System.Convert.ToDateTime("4 July 1776");
            System.Console.WriteLine(aDateTime); // output: 7/04/1776
            Console.ReadLine();
            // Declare a variable of type char named ch and initialize it with the value '7'.
            // Then test it in an if statement to see if it is a letter or a
            // non-letter character. Display output on the console that indicates
            // whether it is a letter or a non-letter.
            System.Char ch = Convert.ToInt32;
            ch = 7;
            if (ch == Char)
            {
                return true;
            }
            else:
                {
                return false;
            }
        }
    }
}