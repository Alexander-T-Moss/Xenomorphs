namespace Xenomorphs;

public class Character
{
	public string? Name;
	public int HitPoints = 1;

    public string GetName()
    {
        if (Name != null)
        {
            return Name;
        }

        else
        {
            return "Nameless";
        }
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public int GetHitPoints()
    {
        return HitPoints;
    }

    public void Damage(int damage)
    {
        HitPoints -= damage;
    }
}