namespace Game;

class Item
{
    public int ID;
    public string Name;
    public string PluralName;

    public Item(int id, string name, string pluralName)
    {
        ID = id;
        Name = name;
        PluralName = pluralName;
    }
}