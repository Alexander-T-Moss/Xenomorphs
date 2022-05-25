namespace Xenomorphs;

public class Xenomorph : Character
{
    public int KillCount = 0;

    public Xenomorph(string name = "Kane's Son", int hitPoints = 3)
    {
        Name = name;
        HitPoints = hitPoints;
    }

    public int GetKillCount()
    {
        return KillCount;
    }

    public void Kill(Colonist colonist)
    {
        if (colonist.GetConditon() == 2)
        {
            colonist.SetCondition(0);
            colonist.Damage(1);
            KillCount++;

            Console.WriteLine(Name + " has killed: " + colonist.GetName());
            Console.WriteLine("\nThis brings " + Name + "'s kill count to: " + KillCount);
        }
        else
        {
            Console.WriteLine(Name + " won't kill " + colonist.GetName() + " as they are: " + colonist.StringCondition() + ".");
        }
    }
}