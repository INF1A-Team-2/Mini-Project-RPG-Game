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
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1: View quest log");
        Console.WriteLine("2: View inventory");
        Console.WriteLine("3: Move");
        Console.WriteLine("4: Quit");

        int input;
        try
        {
            input = int.Parse(Console.ReadLine() ?? "0");
        }
        catch
        {
            GameLoop();
            return;
        }

        switch (input)
        {
            case 1:
                Player.QuestLogViewer();
                break;
            
            case 2:
                Player.Inventory.DisplayItems();
                break;
            
            case 3:
                Movement.DoMovement();
                Player.CurrentLocation.QuestAvailableHere?.ShowDialog();
                break;
                
            case 4:
                return;
            
            default:
                GameLoop();
                return;
        }

        GameLoop();
    }
}