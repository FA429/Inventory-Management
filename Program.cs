using System.IO.Pipes;
using Microsoft.VisualBasic;
using sda_onsite_2_inventory_management.src;


internal class Program
{

    private static void Main(string[] args)
    {
        Store store = new("Tamimi");




        var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
        var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var batteries = new Item("Batteries", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);

        List<Item> items = store.GetItems();
        store.AddItem(pen);
        store.AddItem(sodaCan);
        store.AddItem(chocolateBar);
        store.AddItem(sunscreen);

        store.RemoveItem(toothbrush);
        store.RemoveItem(pen);

       Item? findItem = store.FindByName(sodaCan);
        if (findItem is not null)
        {
            Console.WriteLine(findItem.GetName());
                        Console.WriteLine(findItem.GetQuantity());

        }


        foreach (var item in items)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
/*
            Console.WriteLine("    ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"   ║     NAME : {item.GetName()} QUANTITY : {item.GetQuantity()} CREATED_AT :{item.GetCreatedAt()}   ║");
            Console.WriteLine("    ║                                                                                                 ║");
           Console.WriteLine("    ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");
*/
        }
        Console.WriteLine($" COUNT:{items.Count}");

        Console.WriteLine($"total: {store.GetCurrentVolume()}");
        Console.ForegroundColor = ConsoleColor.Green;

    }

}
