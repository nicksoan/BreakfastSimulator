using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastSimulator.App.Models
{
    public class Toast : IBreakfastItem
    {
        public string Name => "Toast";
        public int PreparationTime => 3; // Example time

        public async Task Prepare()
        {
            Console.WriteLine("Starting to prepare Toast.");
            Console.WriteLine("Selecting desired bread type...");
            await Task.Delay(500); // Choosing bread
            Console.WriteLine("Inserting bread slices into the toaster...");
            await Task.Delay(500); // Placing in toaster
            Console.WriteLine("Setting the toaster to medium and starting it...");
            await Task.Delay(1000); // Starting toaster
            Console.WriteLine("Waiting for toast to pop up...");
            await Task.Delay(2000); // Toasting
            Console.WriteLine("Removing toast and applying butter...");
            await Task.Delay(500); // Buttering toast
            Console.WriteLine("Toast is ready!");
        }
    }
}
