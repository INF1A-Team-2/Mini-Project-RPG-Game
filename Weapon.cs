namespace Game;

public class Weapon
{
    public int ID;
    public string name;
    public string plural;
    public int value1;
    public int value2;

    public Weapon(int weapon_id, string name, string plural, int value1, int value2)
    {
        this.ID = weapon_id;
        this.name = name;
        this.plural = plural;
        this.value1 = value1;
        this.value2 = value2;
        
    }
    
}