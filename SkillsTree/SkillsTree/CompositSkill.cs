namespace SkillsTree;

public class CompositSkill : IComponent
{
    public bool Explored { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    
    public List<IComponent> Components = new List<IComponent>();

    public CompositSkill(bool explored, string description, string name)
    {
        Explored = explored;
        Description = description;
        Name = name;
    }
    
    public void Add(IComponent component)
    {
        Components.Add(component);
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        if(Explored)
            Console.WriteLine("Explored: Yes");
        else
            Console.WriteLine("Explored: No");

        foreach (IComponent component in Components)
        {
            component.Print();
        }
    }
}