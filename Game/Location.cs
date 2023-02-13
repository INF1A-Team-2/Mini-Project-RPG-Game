namespace Game;

public class Location
{
    public int Id;
    public string Name;
    public string Description;
    public Item ItemRequiredToEnter;
    public Quest QuestAvailableHere;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int id, string name, string description, Item itemRequiredToEnter, Quest questAvailableHere,
        Location locationToNorth, Location locationToEast, Location locationToSouth, Location locationToWest)
    {
        this.Id = id;
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