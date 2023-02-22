namespace Game;
class Inventory
{
    public CountedItemList Items = new CountedItemList();

    public void DisplayItems()
    {
        //counteditem en quantity (CountedItemList.cs) gebruiken, op basis van quantity name of pluralname (item.cs)
        
        Console.WriteLine("\nInventory:");
        
        foreach (CountedItem countedItem in Items.Items)
        {
            Console.WriteLine($"{countedItem.Quantity} {(countedItem.Quantity == 1 ? countedItem.Item.Name : countedItem.Item.PluralName)}");
        }
    }

    public bool HasItem(CountedItem item)
    {
        foreach (CountedItem countedItem in Items.Items)
        {
            if (countedItem.Item.ID == item.Item.ID && countedItem.Quantity == item.Quantity)
            {
                return true;
            }
        }

        return false;
    } 
}