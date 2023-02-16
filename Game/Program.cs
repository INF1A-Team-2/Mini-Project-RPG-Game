namespace Game;

static class Program
{
    public static Player Player;

    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine() ?? "Player";

        Player = new Player(name, 10, 10, World.LocationByID(World.LOCATION_ID_HOME));

        GameLoop();
    }

    public static void GameLoop()
    {
        Movement.DoMovement();

        if (Player.CurrentLocation.ItemRequiredToEnter != null)
        {
            // check if the player has the item
        }
        
        GameLoop();
    }
}