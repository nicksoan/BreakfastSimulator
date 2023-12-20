using BreakfastSimulator.App.Factories;

namespace BreakfastSimulator.App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var simulator = new BreakfastSimulator();

            Console.WriteLine("Enter the breakfast items you want (Sausage, Bacon), separated by commas:");
            var input = Console.ReadLine();

            foreach (var itemName in input.Split(','))
            {
                try
                {
                    var item = BreakfastItemFactory.CreateItem(itemName.Trim());
                    simulator.AddItem(item);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            await simulator.PrepareBreakfast();
        }
    }
}
