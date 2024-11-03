namespace GameMax.Class;

public class Items
{
    public static Item GetItembyID(int ItemID)
    {
        switch (ItemID)
        {
            case 1: return new Item("Mask", "Common", 1, 100);
            case 2: return new Item("Bow","Rare",2,20);
            case 3: return new Item("Stone", "Common", 3, 10);
            case 4: return new Item("Stick", "Uncommon", 4, 0);
            case 5: return new Item("Helmet", "Rare", 5, 80);
            case 6: return new Item("Pants", "Common", 6, 50);
            case 7: return new Item("Dimond", "Legendary", 7, 10000);

            default:
                return null;

        }
    }
    public static Item Mask = new Item("Mask", "Common", 1, 100);
    public static Item Bow = new Item("Bow", "Rare", 2, 20);
    public static Item Stone = new Item("Stone", "Common", 3, 10);
    public static Item Stick = new Item("Stick", "Uncommon", 4, 0);
    public static Item Helmet = new Item("Helmet", "Rare", 5, 80);
    public static Item Pants = new Item("Pants", "Common", 6, 50);
    public static Item Dimond = new Item("Dimond", "Legendary", 7, 10000);
}


