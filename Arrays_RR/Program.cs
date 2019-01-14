/*
	Author: Clinton Daniel
	Date: 1/5/2019
	Comments: This C# Console application code demonstrates the use of
	Arrays after getting input from users. 
	
	*/

using System;

namespace Arrays_RR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer between 1 and 20: ");
            /*
            Use the try catch block to validate user input.
            If the user provides bad input, the catch block
            will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                // If the value of user input is between 1 and 10, manually populate an array and iterate throught its values
                if ((value_of_input > 0) && (value_of_input <= 10))
                {
                    Console.WriteLine("");
                    Console.WriteLine("First, let's manually populate an array with integers.");
                    Console.WriteLine("Then, let's iterate through the elements in the array with a foreach loop");
                    // Here is the manually populated array
                    int[] numbers = { 1, 8, 0, 0, 5, 5, 5, 1, 2, 1, 2 };
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("You have entered the number: " + value_of_input);
                    Console.WriteLine("The value is " + numbers[value_of_input] + " in element #" + value_of_input + " of the array.");
                    Console.WriteLine("Here are the values in each element of the array:");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("");
                    // Iterate through the array with a Foreach Loop
                    foreach (int i in numbers)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                } // End of if
                  // If the value of user input is between 11 and 20, automatically populate an array and iterate throught its values
                else if ((value_of_input > 10) && (value_of_input <= 20))
                {
                    Console.WriteLine("");
                    Console.WriteLine("First, let's automatically populate an array with integers based on the value you input.");
                    Console.WriteLine("Then, let's iterate through the elements in the array with a For Loop");
                    // Automatically populate an array with a number of elements input by the user
                    int[] countdown = new int[value_of_input];
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("You have entered the number: " + value_of_input);
                    Console.WriteLine("Therefore, " + value_of_input + " elements should be populated in the array.");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("");
                    int pop_array = 0;
                    // Iterate through the array using a For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        countdown[i] = pop_array;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                } // End of else if
                  // If the user selects a number that is not between 1 and 20 , display a message
                else
                {
                    Console.WriteLine("Please enter an integer value between 1 and 20 next time ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                } // End of else
            } // End of try
              // If a user does not enter an integer, display a message
            catch
            {
                Console.WriteLine("Please input integer values only next time...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of catch
        }
    }
}

