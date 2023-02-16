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
        if (newLocation != null)
        {
            Program.Player.CurrentLocation = newLocation;
            return true;
        }
        return false;
    }
}