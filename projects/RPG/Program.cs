static class Program
{
    static void Main()
    {
        // Unit zombie = new Unit("Zombie", 100);
        // Unit skeleton = new Unit("Skeleton", 200);
        // Unit necromancer = new Unit("Necromancer", 500);
        
        Unit leet = new Unit("Leet", 1337);

        while (leet.IsAlive)
        {
            Console.WriteLine($"How much damage do you want to deal to {leet}?");
            leet.Damage(int.Parse(Console.ReadLine()));
        }

    }
}

public class Unit
{
    public string Name { get; }
    public int id;
    public static int nextId;

    public bool IsAlive
    {
        get
        {
            if (health > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} is dead");
                return false;
                
            }
        }
    }
    
    private int maxHealth;
    private int health;

    public Unit(string name, int maxHealth)
    {
        Name = name;
        id = nextId;
        nextId++;

        this.maxHealth = maxHealth;
        this.health = maxHealth;
        
        // Make sure, that this is the last line of the constructor.
        ReportStatus();
    }

    public int Health //when we want to GET something we use RETURN and then it should be int instead of void
    {
        private set //now nobody else can change it anymore
        {
            health = Math.Clamp(value, 0, maxHealth);
            ReportStatus();
        }
        get //same as public int GetHealth
        {
            return health;
        }
    }

    public void Damage(int value)
    {
        Health -= value;
    }
   
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");
    }
}