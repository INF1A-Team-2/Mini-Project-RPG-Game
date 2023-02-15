namespace Game;

class Weapon
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MinimumDamage;
    public int MaximumDamage;

    public Weapon(int weapon_id, string name, string plural, int minimumdamage, int maximumdamage)
    {
        this.ID = weapon_id;
        this.Name = name;
        this.NamePlural = plural;
        this.MinimumDamage = minimumdamage;
        this.MaximumDamage = maximumdamage;
        
    }
    
}
