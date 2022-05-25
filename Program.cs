namespace Xenomorphs;

class Program
{
    public static void Main()
    {
        
        Colonist testColonist = new("Riley", "Johnson");
        Facehugger testFacehugger = new(0);
        Xenomorph testXenomorph = new();

        Console.WriteLine("------------------------------------------------------------\n");
        Console.WriteLine("Our players are: \n");
        Console.WriteLine("Colonist: " + testColonist.GetName());
        Console.WriteLine("Facehugger: " + testFacehugger.GetName());
        Console.WriteLine("Xenomorph: " + testXenomorph.GetName());

        Console.WriteLine("\n------------------------------------------------------------\n");

        Console.WriteLine("Updating " + testColonist.GetName() + "'s condition to DEAD (0).\n");
        testColonist.SetCondition(0);
        Console.WriteLine(testColonist.GetName() + " is " + testColonist.StringCondition());

        Console.WriteLine("\nNow updating " + testColonist.GetName() + "'s condition to HEALTHY (2).\n");
        testColonist.SetCondition(2);
        Console.WriteLine(testColonist.GetName() + " is " + testColonist.StringCondition());

        Console.WriteLine("\n------------------------------------------------------------\n");

        Console.WriteLine(testColonist.GetName() + " will now shoot " + testXenomorph.GetName() + " and " + testFacehugger.GetName());

        Console.WriteLine();
        testColonist.Shoot(testXenomorph);
        Console.WriteLine();
        testColonist.Shoot(testFacehugger);

        Console.WriteLine("\n------------------------------------------------------------\n");

        Console.WriteLine("Now " + testXenomorph.GetName() + " will attack " + testColonist.GetName() + "\n");
        testXenomorph.Kill(testColonist);

        Console.WriteLine();
        testColonist.Shoot(testXenomorph);

        Console.WriteLine("\n------------------------------------------------------------\n");









    }
}