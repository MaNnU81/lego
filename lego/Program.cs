using lego.Logic;
using lego.model;

namespace lego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new LegoContext();
            var colorRepo = new LegoRepository<LegoColor>(context);
            var colors = colorRepo.GetAll();
            foreach (var color in colors)
            {
                Console.WriteLine($"Part ID: {color.Id}, Name: {color.Name}");
            }


            var inventoryRepo = new LegoRepository<LegoInventory>(context);
            var inventories = inventoryRepo.GetAll();
            foreach (var inventory in inventories)
            {
                Console.WriteLine($"Inventory ID: {inventory.Id}, Set ID: {inventory.Version}");
            }

            


            //    var parts = context.LegoParts.ToList();
            //    foreach (var part in parts)
            //    {
            //        Console.WriteLine($"Part ID: {part.PartNum}, Name: {part.Name}");
            //    }
            //}
        }
    }
}
