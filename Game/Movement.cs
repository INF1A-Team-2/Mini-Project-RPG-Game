namespace Game;

class Movement
{
    public void DoMovement(Player player)
    {
        Console.WriteLine("Where do you want to go? (N/E/S/W)");
        string direction = Console.ReadLine().ToUpper();
        TryMoveTo(player.CurrentLocation.GetLocationAt(direction), player);
        Console.WriteLine("Current location: " + player.CurrentLocation.Name);
        Console.WriteLine(player.CurrentLocation.Compass());
    }
    
    public bool TryMoveTo(Location newLocation, Player player)
    {
        if (newLocation != null)
        {
            player.CurrentLocation = newLocation;
            return true;
        }
        return false;
    }
}