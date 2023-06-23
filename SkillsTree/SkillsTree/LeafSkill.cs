namespace SkillsTree;

public class LeafSkill : IComponent
{
    public bool Explored { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    
    public LeafSkill(bool explored, string description, string name)
    {
        Explored = explored;
        Description = description;
        Name = name;
    }
    
    
    
    public void Add(IComponent component)
    {
        
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        if(Explored)
            Console.WriteLine("Explored: Yes");
        else
            Console.WriteLine("Explored: No");
    }
}