using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastSimulator.App.Models
{
    public interface IBreakfastItem
    {
        string Name { get; }
        int PreparationTime { get; }
        Task Prepare();
    }
}
