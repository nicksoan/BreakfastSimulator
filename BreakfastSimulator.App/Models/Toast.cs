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
            Console.WriteLine("Putting bread in the toaster...");
            await Task.Delay(1000); // Simulate placing in toaster
            Console.WriteLine("Toasting...");
            await Task.Delay(2000); // Simulate toasting
            Console.WriteLine("Toast is ready!");
        }
    }
}
