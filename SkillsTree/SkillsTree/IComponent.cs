namespace SkillsTree;

public interface IComponent
{
    public abstract bool Explored { get; set; }
    public abstract string Description { get; set; }
    public abstract string Name { get; set; }

    public void Add(IComponent component);
    public void Print();
}