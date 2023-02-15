namespace Game;

class Monster
{
  public int ID;
  public string Name;
  public string NamePlural;
  public int MaximumDamage;
  public int RewardExperience;
  public int RewardGold;
  public Loot CountedItemList;
  public int CurrentHitPoints;


  public Monster(int id, string name, string nameplural, int maximumdamage, int rewardexperience, int rewardgold, Loot counteditemlist, int currenthitpoints) //constructor?
  {
    //put constructor code here
    this.ID = id;
    this.Name = name;
    this.NamePlural = nameplural;
    this.MaximumDamage = maximumdamage;
    this.RewardExperience = rewardexperience;
    this.RewardGold = rewardgold;
    this.CountedItemList = counteditemlist;
    this.CurrentHitPoints = currenthitpoints;
  
  }

}
