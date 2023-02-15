namespace Game;

class CountedItem
{
    public Item Item;
    public int Quantity;

    public CountedItem(Item item, int quantity)
    {
        this.Item = item;
        this.Quantity = quantity;
    }
}