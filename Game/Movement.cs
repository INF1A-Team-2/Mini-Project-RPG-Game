namespace Game;

class Movement
{
    public void DoMovement()
    {
        Console.WriteLine("Where do you want to go? (N/E/S/W)");
        string direction = Console.ReadLine().ToUpper();
        TryMoveTo(Program.player.CurrentLocation.GetLocationAt(direction));
        Console.WriteLine("Current location: " + Program.player.CurrentLocation.Name);
        Console.WriteLine(Program.player.CurrentLocation.Compass());
    }
    
    public bool TryMoveTo(Location newLocation)
    {
        if (newLocation != null)
        {
            Program.player.CurrentLocation = newLocation;
            return true;
        }
        return false;
    }
}