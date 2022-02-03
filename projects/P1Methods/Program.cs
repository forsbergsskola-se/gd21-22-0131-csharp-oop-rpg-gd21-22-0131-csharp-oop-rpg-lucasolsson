//Call the method
Main();

static void Main()
{
    Count(2,3);
    Count(100,101);
    Count(10,8);
    Count(1,-1);
    Count(1337,1337);
}

static void Count(int from, int to) //Count method
{
    if (from < to)
    {
        Console.WriteLine($"Counting from {from} to {to}:");
        for (int counter = from; counter <= to; counter++)
         {
            Console.WriteLine(counter);
         }
    }
    else
    {
        Console.WriteLine($"Counting from {from} to {to}:");
        for (int counter = from; counter >= to; counter--)
        {
            Console.WriteLine(counter); 
        }
    }
}