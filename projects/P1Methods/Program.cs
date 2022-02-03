//Call the method
Main();

static void Main()
{
    for (int i = 0; i <= 1; i++)
    {
        CountUp();
        CountDown();
    }
}

static void CountUp() //CountUp method
{
    Console.WriteLine("Counting from 0 to 5:");
    for (int counter = 0; counter <= 5; counter++) // condition-statement
    {
        Console.WriteLine(counter); // loop-body
    }
}
// initial-statement = int counter = 0;
// condition-statement = counter <= 5; 
// loop-body = Console.WriteLine(counter); (write out the counter number until int counter is equal to 5)
// iteration-statement = counter++ (make sure the counter continue of ticking up)

static void CountDown() //CountDown method
{
    Console.WriteLine("Counting from 5 to 0:");
    for (int counter = 5; counter >= 0; counter--)
    {
        Console.WriteLine(counter); 
    }
}
// initial-statement = int counter = 5;
// condition-statement = counter >= 0; 
// loop-body = Console.WriteLine(counter); (write out the counter number until int counter is equal to 0)
// iteration-statement = counter-- (make sure the counter continue of ticking down)