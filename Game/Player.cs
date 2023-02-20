﻿namespace Game;

class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int Gold = 0;
    public int ExperiencePoints = 0;
    public int Level = 0;
    public Weapon CurrentWeapon = null;
    public Location CurrentLocation;
    public Inventory Inventory = new Inventory();
    public List<PlayerQuest> QuestLog = new List<PlayerQuest>();
    

    public Player(string name, int currentHitPoints, int maximumHitPoints, Location currentLocation)
    {
        this.Name = name;
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentLocation = currentLocation;
    }

    public void QuestLogViewer()
    {
        foreach (var quest in QuestLog)
        {
            Console.WriteLine($"Quest: {quest.Quest.Name}");
            Console.WriteLine($"Description: {quest.Quest.Description}");
            Console.WriteLine("Quest completed: " + quest.IsCompleted);
            Console.WriteLine();
        }
    }
}
