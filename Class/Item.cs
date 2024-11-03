
namespace GameMax.Class;

public class Item
{
    public string Name { get; set; }
    public string Rarity { get; set; }
    public int ItemID { get; set; }
    public int Cost { get; set; }
    public Item(string name, string rarity, int itemid, int cost) 
    {
        Name = name;
        Rarity = rarity;
        ItemID = itemid;
        Cost = cost;
    }
    



 

}
