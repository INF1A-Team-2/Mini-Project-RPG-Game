namespace Game;

class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int Gold;
    public int ExperiencePoints;
    public int Level;
    public Weapon CurrentWeapon;
    public Location CurrentLocation;
    public CountedItemList Inventory = new CountedItemList(); 
    public QuestLog QuestList = new QuestLog();

    public Player(string name, int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level, Weapon currentWeapon, Location currentLocation)
    {
        this.Name = name;
        this.CurrentHitPoints = currentHitPoints;
        this.MaximumHitPoints = maximumHitPoints;
        this.Gold = gold;
        this.ExperiencePoints = experiencePoints;
        this.Level = level;
        this.CurrentWeapon = currentWeapon;
        this.CurrentLocation = currentLocation;
    }
}