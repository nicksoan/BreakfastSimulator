using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastSimulator.App.Models
{
    public class Tea : IBreakfastItem
    {
        public string Name => "Tea";
        public int PreparationTime => 5; // Example time

        public async Task Prepare()
        {
            Console.WriteLine("Filling the kettle with water...");
            await Task.Delay(1000); // Simulate filling the kettle
            Console.WriteLine("Boiling water in the kettle...");
            await Task.Delay(3000); // Simulate boiling water

            Console.WriteLine("Placing a teabag in the cup...");
            await Task.Delay(500); // Placing teabag in cup
            Console.WriteLine("Pouring boiling water into the cup over the teabag...");
            await Task.Delay(1000); // Pouring hot water

            Console.WriteLine("Letting the tea brew for about 3 minutes...");
            await Task.Delay(3000); // Brewing time

            Console.WriteLine("Removing the teabag from the cup...");
            await Task.Delay(500); // Removing teabag
            Console.WriteLine("Adding milk and sugar as desired...");
            await Task.Delay(1000); // Adding milk and sugar

            Console.WriteLine("Stirring the tea...");
            await Task.Delay(500); // Stirring
            Console.WriteLine("Tea is ready!");
        }
    }
}
