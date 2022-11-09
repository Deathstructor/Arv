
public class MechComponent
{
    public string Name { get; set; }
    public int Weight { get; set; }
}

public class Weapon : MechComponent
{
    public int Damage { get; set; }

    public Weapon()
    {
        Name = "Excalibur";
        Damage = 15;
    }
}

public class Armor : MechComponent
{
    public int Rating { get; set; }

    public Armor()
    {
        Name = "Iron Armor";
        Rating = 10;
    }
}