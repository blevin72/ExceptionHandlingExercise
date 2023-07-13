using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr--DONE!
            // Create a list called numbers that will hold integers--DONE!
            // Create a string variable with an empty string initializer - name it str--DONE!

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()--DONE!
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:
            char[] numsAndLetters = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            List<int> myNumbers = new List<int>();
            string str = null;

            // Make a foreach loop to iterate through your character array--DONE!
            foreach (char i in numsAndLetters)
            {
                try
                {
                    str = i.ToString();
                    int numsAndLett = int.Parse(str);
                    myNumbers.Add(numsAndLett);
                }
                catch
                {
                    Console.WriteLine($"Unable to Parse '{i}'");
                }
            }

            // Now create a try catch
            
            foreach (var num in myNumbers)
            {
                Console.WriteLine(num);
            }

            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()--DONE!
            // Now, using int.Parse, parse your string variable and store in an int variable--DONE!
            // Then add each int to your list--DONE!

            // catch your Exception:
            // in the scope of your catch you can use the following,--DONE! 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



         
        }
    }
}
