namespace Game;

class Item
{
    public int ID;
    public string Name;
    public string PluralName;

    public Item(int id, string namee, string pluralName)
    {
        this.ID = id;
        this.Name = namee;
        this.PluralName = pluralName;
    }
}