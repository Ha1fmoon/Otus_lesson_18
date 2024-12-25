namespace ConsoleApp1;

// Предмет в игре может обладать следующими свойствами:
// Consumable
//     Equipable
// QuestItem
//     Tradeable
// Legendary
//
//     У персонажа может быть несколько предметов
//     У нашего первого персонажа будут Equipable и Legendary меч, Equipable и QuestItem амулет и Tradeable зелье

class Program
{
    static void Main(string[] args)
    {
        var character = new Character();
        
        var firstItem = new Item("Меч", ItemStatus.Equipable | ItemStatus.Legendary);
        var secondItem = new Item("амулет", ItemStatus.Equipable | ItemStatus.QuestItem);
        var thirdItem = new Item("зелье", ItemStatus.Tradeable);
        // character.GetItem();
    }
}

//00010
//
//10000