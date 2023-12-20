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
            var preparationTasks = _selectedItems.Select(item => StartPreparing(item, maxPreparationTime));
            await Task.WhenAll(preparationTasks);
            Console.WriteLine("All breakfast items are ready!");
        }

        private async Task StartPreparing(IBreakfastItem item, int maxPreparationTime)
        {
            int delayStart = maxPreparationTime - item.PreparationTime;
            if (delayStart > 0)
            {
                Console.WriteLine($"Waiting to start {item.Name} in {delayStart} seconds.");
                await Task.Delay(delayStart * 1000);
            }

            await item.Prepare();
        }
    }
}
