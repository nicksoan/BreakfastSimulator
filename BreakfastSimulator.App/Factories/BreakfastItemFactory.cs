using BreakfastSimulator.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastSimulator.App.Factories
{
    public static class BreakfastItemFactory
    {
        private static Dictionary<string, Func<IBreakfastItem>> itemCreators = new Dictionary<string, Func<IBreakfastItem>>
    {
        {"sausages", () => new Sausage()},
        {"bacon", () => new Bacon()},
        {"tea", () => new Tea()},
        {"toast", () => new Toast()},
    };

        public static IBreakfastItem CreateItem(string itemName)
        {
            if (itemCreators.TryGetValue(itemName.ToLower(), out var creator))
            {
                return creator();
            }

            throw new ArgumentException($"No item found for {itemName}");
        }
    }
}
