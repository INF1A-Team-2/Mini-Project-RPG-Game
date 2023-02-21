namespace Game;

static class Movement
{
    public static void DoMovement()
    {
        Console.WriteLine("Where do you want to go? (N/E/S/W)");
        string direction = (Console.ReadLine() ?? "").ToUpper();
        TryMoveTo(Program.Player.CurrentLocation.GetLocationAt(direction));
        Console.WriteLine("Current location: " + Program.Player.CurrentLocation.Name);
        Console.WriteLine(Program.Player.CurrentLocation.Description);
        Console.WriteLine(Program.Player.CurrentLocation.Compass());
    }
    
    public static bool TryMoveTo(Location newLocation)
    {
        if (newLocation != null & newLocation.ItemRequiredToEnter == null)
        {
            Program.Player.CurrentLocation = newLocation;
            return true;
        }
        if (newLocation != null & newLocation.ItemRequiredToEnter != null)
        {
            foreach (CountedItem item in Program.Player.Inventory.Items.Items)
            {
                if (item.Item == newLocation.ItemRequiredToEnter)
                {
                    Program.Player.CurrentLocation = newLocation;
                    return true;
                }
            }
            Console.WriteLine("You need a " + newLocation.ItemRequiredToEnter.Name + " to enter this location.");
            return false;
        }
        return false;
    }
}