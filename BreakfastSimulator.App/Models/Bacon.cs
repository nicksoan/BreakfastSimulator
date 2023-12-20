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
        public int PreparationTime => 5;

        public async Task Prepare()
        {
            Console.WriteLine("Starting to prepare Bacon.");
            Console.WriteLine("Heating the skillet...");
            await Task.Delay(1000); // Simulate heating skillet
            Console.WriteLine("Placing bacon in the skillet...");
            await Task.Delay(2000); // Simulate initial cooking
            Console.WriteLine("Flipping bacon...");
            await Task.Delay(4000); // Simulate cooking after flipping
            Console.WriteLine("Bacon is ready!");
        }
    }
}
