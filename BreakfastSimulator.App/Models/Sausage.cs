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
        public int PreparationTime => 10;

        public async Task Prepare()
        {
            Console.WriteLine("Starting to prepare Sausage.");
            Console.WriteLine("Heating the pan...");
            await Task.Delay(2000); // Simulate heating pan
            Console.WriteLine("Placing sausages in the pan...");
            await Task.Delay(3000); // Simulate initial cooking
            Console.WriteLine("Turning sausages...");
            await Task.Delay(5000); // Simulate cooking on the other side
            Console.WriteLine("Sausage is ready!");
        }
    }
}
