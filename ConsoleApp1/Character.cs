namespace ConsoleApp1;

public class Character
{
    public List<Item> Items { get; set; } = new List<Item>();

    public void GetItem(Item item)
    {
        Items.Add(item);
    }
}