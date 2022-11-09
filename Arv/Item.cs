
public class Item
{
    protected Random rdm = new Random();

    public string Name { get; set; }
    public int Rarity { get; set; }
}

public class Crystal : Item
{
    public Crystal()
    {
        Name = "Ruby";
        Rarity = rdm.Next(3, 6);
    }
}

public class Tool : Item
{
    public Tool()
    {
        Name = "Hammer";
        Rarity = rdm.Next(0, 3);
    }
}