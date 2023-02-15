namespace Game;

public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Item ItemRequiredToEnter;
    public Quest QuestAvailableHere;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null,
        Location locationToNorth = null, Location locationToEast = null, Location locationToSouth = null, Location locationToWest = null)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.ItemRequiredToEnter = itemRequiredToEnter;
        this.QuestAvailableHere = questAvailableHere;
        this.LocationToNorth = locationToNorth;
        this.LocationToEast = locationToEast;
        this.LocationToSouth = locationToSouth;
        this.LocationToWest = locationToWest;
    }
}