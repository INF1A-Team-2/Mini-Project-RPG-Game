using System.Runtime.CompilerServices;

namespace Game;

class Item
{
    this.ID = id;
    this.Name = name;
    this.PluralName = pluralName;

    public Item(int id, string name, string pluralName)
    {
        ID = id;
        Name = name;
        PluralName = pluralName;
    }
}