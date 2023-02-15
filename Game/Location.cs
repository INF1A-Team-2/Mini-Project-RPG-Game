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
}