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
        public int PreparationTime => 2;

        public async Task Prepare()
        {
            Console.WriteLine("Starting to prepare Tea.");
            Console.WriteLine("Boiling water...");
            await Task.Delay(3000); // Simulate boiling water
            Console.WriteLine("Steeping the tea...");
            await Task.Delay(2000); // Simulate steeping
            Console.WriteLine("Tea is ready!");
        }
    }
}
