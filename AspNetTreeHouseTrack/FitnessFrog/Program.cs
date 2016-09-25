using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            int runningTotal = 0;
            
            // Repeat until the user quits
            while (quit != true)
            {
                
                
                // Prompt the user for minutes exercised
                Console.Write("Please enter the minutes exercised: ");
                string entry = Console.ReadLine();
                if (entry != "quit")
                {
                    int minutes = int.Parse(entry);
                    // Add minutes exercised to total
                    runningTotal = runningTotal + minutes;
                }
                else
                {
                    break;
                }
                

                

                // Display total minutes exercised to the screen
                Console.WriteLine("You've exercised " + runningTotal + " minutes");
            }
            

            


        }
    }
}
