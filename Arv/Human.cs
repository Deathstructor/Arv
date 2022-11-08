using System;

public class Human
{
    public string Name { get; set; } = "Bob";
    public int Age { get; set; } = 17;
}

public class Student : Human
{
    public string School { get; set; } = "NTI Stockholm";
}

