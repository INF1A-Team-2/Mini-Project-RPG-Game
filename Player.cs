﻿namespace Game;

class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int Gold = 0;
    public int ExperiencePoints = 0;
    public int Level = 0;
    public Weapon CurrentWeapon = null;
    public Location CurrentLocation;
    public CountedItemList Inventory = new CountedItemList();
    public List<PlayerQuest> QuestLog = new List<PlayerQuest>();
    public int Healthpoints = 100;

    public Player(string name, int currentHitPoints, int maximumHitPoints, Location currentLocation)
    {
        this.Name = name;
        this.CurrentHitPoints = currentHitPoints;
        this.MaximumHitPoints = maximumHitPoints;
        this.CurrentLocation = currentLocation;
    }
}