using BreakfastSimulator.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastSimulator.App
{
    public class BreakfastSimulator
    {
        private List<IBreakfastItem> _selectedItems;

        public BreakfastSimulator()
        {
            _selectedItems = new List<IBreakfastItem>();
        }

        public void AddItem(IBreakfastItem item)
        {
            _selectedItems.Add(item);
        }

        public async Task PrepareBreakfast()
        {
            int maxPreparationTime = _selectedItems.Max(item => item.PreparationTime);
            var preparationTasks = new List<Task>();

            foreach (var item in _selectedItems)
            {
                int delayStart = maxPreparationTime - item.PreparationTime;
                var preparationTask = Task.Run(async () =>
                {
                    if (delayStart > 0)
                    {
                        Console.WriteLine($"Waiting to start {item.Name} in {delayStart} seconds.");
                        await Task.Delay(delayStart * 1000);
                    }
                    await item.Prepare();
                });

                preparationTasks.Add(preparationTask);
            }

            await Task.WhenAll(preparationTasks);
            Console.WriteLine("Breakfast is served...");
        }
    }
}
