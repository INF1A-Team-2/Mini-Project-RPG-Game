namespace Game;

public class Weapon
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MinimumDamage;
    public int MaximumDamage;

    public Weapon(int weapon_id, string name, string plural, int value1, int value2)
    {
        this.ID = weapon_id;
        this.Name = name;
        this.NamePlural = plural;
        this.MinimumDamage = value1;
        this.MaximumDamage = value2;
        
    }
    
}
