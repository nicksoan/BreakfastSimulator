using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastSimulator.App.Models
{
    public class Bacon : IBreakfastItem
    {
        public string Name => "Bacon";
        public int PreparationTime => 8; // Example time

        public async Task Prepare()
        {
            Console.WriteLine("Starting to prepare Bacon.");
            Console.WriteLine("Heating the skillet over medium heat...");
            await Task.Delay(1000); // Simulate heating skillet
            Console.WriteLine("Laying bacon strips in the skillet without overlapping...");
            await Task.Delay(1000); // Placing bacon
            Console.WriteLine("Cooking bacon for 3 minutes until it starts to curl...");
            await Task.Delay(3000); // Simulate initial cooking
            Console.WriteLine("Flipping bacon and cooking for another 3 minutes...");
            await Task.Delay(3000); // Simulate cooking after flipping
            Console.WriteLine("Draining bacon on paper towels...");
            await Task.Delay(1000); // Draining
            Console.WriteLine("Bacon is ready!");
        }
    }
}
