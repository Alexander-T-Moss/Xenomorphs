namespace Xenomorphs;

public class Facehugger : Character
{
    public bool HasEmbryo;
    public int Number;

    public Facehugger(int number, string? name = "Facehugger", bool hasEmbryo = true)
    {
        Number = number;
        Name = name;
        HasEmbryo = hasEmbryo;
        HitPoints = 1;
    }

    public int? GetNumber()
    {
        return Number;
    }

    public void Hug(Colonist colonist)
    {
        if (HasEmbryo)
        {
            colonist.SetCondition(1);
            Console.WriteLine(Name + " has attached itself to " + colonist.GetName() + "'s face. They are now unconscious.");
        }
        else
        {
            Console.WriteLine(Name + " has no embryo.");
        }
    }
}