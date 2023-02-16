namespace Game;

class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Item ItemRequiredToEnter;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth = null;
    public Location LocationToEast = null;
    public Location LocationToSouth = null;
    public Location LocationToWest = null;

    public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null,
        Monster monsterLivingHere = null)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.ItemRequiredToEnter = itemRequiredToEnter;
        this.QuestAvailableHere = questAvailableHere;
        this.MonsterLivingHere = monsterLivingHere;
    }
    
    public Location GetLocationAt(string direction)
    {
        switch (direction)
        {
            case "N":
                return LocationToNorth;
            case "E":
                return LocationToEast;
            case "S":
                return LocationToSouth;
            case "W":
                return LocationToWest;
            default:
                return null;
        }
    }

    public string Compass()
    {
        string compass = "";
        if (LocationToNorth != null)
        {
            compass += "    N\n    |\n";
        }

        if (LocationToWest != null)
        {
            compass += "W---|";
        }
        else
        {
            compass += "    |";
        }
        
        if (LocationToEast != null)
        {
            compass += "---E\n";
        }
        else
        {
            compass += "\n";
        }
        if (LocationToSouth != null)
        {
            compass += "    |\n    S";
        }

        return compass;
    }
}

Player player = new Player("John Doe", 10, 100, World.Locations[0]); //Creates a Player object and puts him at Location 1
Console.WriteLine("Current location: " + player.CurrentLocation.Name);
Console.WriteLine(player.CurrentLocation.Compass()); //Can be used to see the movement options


//while (player.CurrentLocation.Name != "Goal")
while (true)
{
    Console.WriteLine("Where do you want to go? (N/E/S/W)");
    string direction = Console.ReadLine().ToUpper();
    player.TryMoveTo(player.CurrentLocation.GetLocationAt(direction));
    Console.WriteLine("Current location: " + player.CurrentLocation.Name);
    Console.WriteLine(player.CurrentLocation.Compass());
}