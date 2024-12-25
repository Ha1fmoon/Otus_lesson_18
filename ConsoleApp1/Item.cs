namespace ConsoleApp1;

public class Item
{
    public string ItemName { get; set; }
    
    public ItemStatus ItemStatus { get; set; }

    public Item(string name, ItemStatus status)
    {
        ItemName = name;
        ItemStatus = status;
    }
}