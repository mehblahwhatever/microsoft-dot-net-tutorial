using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugSample { 
    class DebugSample {
        static void Main(string[] args) {
            int ageValue = 0;
            string ageString = "";

            // Ask for the user's age
            Console.Write("Enter your age: ");
            ageString = Console.ReadLine();

            try {
                ageValue = Convert.ToInt32(ageString);

                // Display the correct statement based on the results
                if ((ageValue >= 13) && (ageValue < 200) {
                    Console.WriteLine("You are a teenage.");
                } else {
                    Console.WriteLine("You are a real person.");
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
