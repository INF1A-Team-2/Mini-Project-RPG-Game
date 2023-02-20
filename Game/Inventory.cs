namespace Game;
class Inventory
{
    public CountedItemList Items = new CountedItemList();

    public void DisplayItems()
    {
        //counteditem en quantity (CountedItemList.cs) gebruiken, op basis van quantity name of pluralname (item.cs)

        foreach (CountedItem countedItem in Items.Items)
        {
            if (countedItem.Quantity == 1)
            {
                Console.WriteLine($"{countedItem.Quantity} {countedItem.Item.Name}/n");
            }

            if (countedItem.Quantity >= 1)
            {
                Console.WriteLine($"{countedItem.Quantity} {countedItem.Item.PluralName}/n");
            }

        }

    }





}