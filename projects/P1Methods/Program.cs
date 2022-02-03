//Call the method
Main();

static void Main()
{
    CountUp(0,1);
    CountDown(1,0);
    CountUp(0,2);
    CountDown(2,0);
    CountUp(0,3);
    CountDown(3,0);
}

static void CountUp(int from, int to) //CountUp method
{
    Console.WriteLine($"Counting from {from} to {to}:");
    for (int counter = from; counter <= to; counter++) // condition-statement
    {
        Console.WriteLine(counter); // loop-body
    }
}
// initial-statement = int counter = x number;
// condition-statement = counter <= x; 
// loop-body = Console.WriteLine(counter); (write out the counter number until int counter is equal to 5)
// iteration-statement = counter++ (make sure the counter continue of ticking up)

static void CountDown(int from, int to) //CountDown method
{
    Console.WriteLine($"Counting from {from} to {to}:");
    for (int counter = from; counter >= to; counter--)
    {
        Console.WriteLine(counter); 
    }
}
// initial-statement = int counter = x number;
// condition-statement = counter >= x; 
// loop-body = Console.WriteLine(counter); (write out the counter number until int counter is equal to 0)
// iteration-statement = counter-- (make sure the counter continue of ticking down)