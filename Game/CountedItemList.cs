namespace Game;

class CountedItemList
{
    public List<CountedItem> ItemList = new List<CountedItem>();

    public void AddItem(CountedItem item)
    {
        ItemList.Add(item);
    }
}