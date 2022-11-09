
public class Character
{
    public string Name { get; set; }
    public int ForceSensitivity { get; set; }
    public string ForceSide { get; set; }
}

public class ForceUser : Character
{
    
}

public class Jedi : ForceUser
{
    public Jedi()
    {
        ForceSide = "Light";
    }
}

public class Sith : ForceUser
{
    public Sith()
    {
        ForceSide = "Dark";
    }
}