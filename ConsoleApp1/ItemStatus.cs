namespace ConsoleApp1;

[Flags]
public enum ItemStatus
{
    Consumable = 1,
    Equipable = 2,
    QuestItem = 4,
    Tradeable = 8,
    Legendary = 16
}