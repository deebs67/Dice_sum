using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_sum_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry stuff
            Console.Title = "Dice sum";
            Console.WriteLine("\nMonte-Carlo simulation to find the PMF of the sum of two random dice");
            Console.WriteLine("====================================================================\n");

            // Number of iterations
            long number_of_iterations = 1000000000;
            Console.WriteLine($"Number of iterations: {number_of_iterations}");

            // Initialse random number generator
            Random my_random = new Random();

            // Create and initialise the array
            var dice_sum_counter_array = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  // It goes from 0..14 inclusive

            // Main simulation loop
            Console.WriteLine("\nCounter index, Counter value");
            Console.WriteLine("----------------------------\n");
            for (int i = 0; i < number_of_iterations; i++)
            {
                // Throw two dice and calculate the sum
                int first_die_value = my_random.Next(1, 7);
                int second_die_value = my_random.Next(1, 7);
                int sum_of_die_values = first_die_value + second_die_value;
                //Console.WriteLine($"First die value: {first_die_value}, Second die value: {second_die_value}, sum_of_die_values: {sum_of_die_values}"); // debug

                // Now increment the appropriate counter in the array
                dice_sum_counter_array[sum_of_die_values]++;
            }

            // Write out each dice_sum counter value
            for (int i = 0; i < 15; i++)
                Console.WriteLine($"{i}, {dice_sum_counter_array[i]}");

            // Exit stuff
            Console.WriteLine("\nSimulation completed, press any key to continue...");
            Console.ReadKey();
        }
    }
}
