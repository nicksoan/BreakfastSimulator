using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastSimulator.App.Models
{
    public class Sausage : IBreakfastItem
    {
        public string Name => "Sausage";
        public int PreparationTime => 10; // Example time

        public async Task Prepare()
        {
            Console.WriteLine("Starting to prepare Sausage.");
            Console.WriteLine("Heating the pan over medium heat...");
            await Task.Delay(2000); // Simulate heating pan
            Console.WriteLine("Adding a small amount of oil to the pan...");
            await Task.Delay(1000); // Simulate adding oil
            Console.WriteLine("Placing sausages in the pan...");
            await Task.Delay(1000); // Placing sausages
            Console.WriteLine("Cooking sausages for 4 minutes on one side...");
            await Task.Delay(4000); // Simulate cooking on one side
            Console.WriteLine("Turning sausages to cook on the other side...");
            await Task.Delay(3000); // Simulate cooking on the other side
            Console.WriteLine("Checking sausages for a golden-brown finish...");
            await Task.Delay(1000); // Final check
            Console.WriteLine("Sausage is ready!");
        }
    }
}
