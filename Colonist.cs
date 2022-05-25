namespace Xenomorphs;

public class Colonist : Character
{
    private string? Job;
    private int Condition = 2;

    private readonly string[] CurrentCondition = { "Dead", "Unconscious", "Healthy" };

    public Colonist(string? name = null, string? job = null)
    {
        Name = name;
        Job = job;
    }

    public string? GetJob()
    {
        return Job;
    }

    public void SetJob(string? job = null)
    {
        Job = job;
    }

    public int? GetConditon()
    {
        return Condition;
    }

    public void SetCondition(int condition)
    {
        Condition = condition;
    }

    public string StringCondition()
    {
        return CurrentCondition[Convert.ToInt32(Condition)];
    }

    public void PrintCondition()
    {
        Console.WriteLine(Name + " is currently: " + CurrentCondition[Convert.ToInt32(Condition)]);
    }

    public void Shoot(Character enemy)
    {
        Type enemyType = enemy.GetType();

        if (GetHitPoints() == 1 && GetConditon() == 2)
        {
            if (enemyType.Equals(typeof(Xenomorph)))
            {
                enemy.Damage(1);
                if (enemy.GetHitPoints() <= 0)
                {
                    Console.WriteLine(Name + " has shot and killed " + enemy.GetName());
                }
                else
                {
                    Console.WriteLine(Name + " has wounded " + enemy.GetName() + " leaving them with " + enemy.GetHitPoints() + " hit points");
                }
            }

            else if (enemyType.Equals(typeof(Facehugger)))
            {
                Random rand = new();
                int hit = Convert.ToInt32(rand.Next(0, 1));

                if (enemy.GetHitPoints() >= 1)
                {
                    if (hit == 1)
                    {
                        enemy.Damage(1);

                        if (enemy.GetHitPoints() <= 0)
                        {
                            Console.WriteLine(Name + " has shot and killed " + enemy.GetName());
                        }
                    }
                    else
                    {
                        Console.WriteLine(Name + " panics and misses");
                    }
                }

                else
                {
                    Console.WriteLine(enemy.GetName() + " is already dead");
                }

            }
        }

        else
        {
            Console.WriteLine(Name + " is unable to shoot");
        }

    }
}