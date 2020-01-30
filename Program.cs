using System;

namespace IterativeDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 1 and 100, please."); //initial instruction

            try
            {
                // read what the person typed
                string input = Console.ReadLine();
                int number = int.Parse(input); // assign it

                if ((number >= 1) && (number <= 100)) // have to make sure the number is valid, if not the catch will save the program from a downward spiral
                {
                    Console.WriteLine("You have entered " + number.ToString() + ", so we're going to run the loop " + number.ToString() + " times."); // after user enters something
                    for (int x = 0; x < number; x++)
                    {
                        Console.WriteLine("The current integer value in the loop is: " + x.ToString() + ". Push any key so we can continue the loop");
                        Console.ReadKey(true);
                    }
                    Console.WriteLine("You can press any key to exit. Loop has completed"); // The loop ends now
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Exiting the program, the number is out of bounds. Please press any key to exit and try again."); // if you type in a number out of bounds, such as greater than 100, it will exit.
                    Console.ReadKey(true);
                }
            }

            catch // if the number that is typed isn't a number, this will catch it
            {
                Console.WriteLine("You did not enter a valid integer. Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }
        }
    }
}
        
    

