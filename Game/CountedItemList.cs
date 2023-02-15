namespace Game;

class CountedItemList
{
    public List<CountedItem> Items = new List<CountedItem>();

    public void AddItem(Item item)
    {
        foreach (CountedItem countedItem in Items)
        {
            if (countedItem.Item.ID == item.ID)
            {
                countedItem.Quantity++;
                return;
            }
        }
        
        Items.Add(new CountedItem(item, 1));
    }

    public void AddCountedItem(CountedItem item)
    {
        foreach (CountedItem countedItem in Items)
        {
            if (countedItem.Item.ID == item.Item.ID)
            {
                countedItem.Quantity += item.Quantity;
                return;
            }
        }
        
        Items.Add(item);
    }
}