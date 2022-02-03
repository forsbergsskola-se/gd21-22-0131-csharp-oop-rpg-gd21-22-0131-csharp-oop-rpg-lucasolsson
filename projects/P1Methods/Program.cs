//Call the Main method
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
    if (from < to) //Do this if the number "from" smaller than number "to"
    {
        Console.WriteLine($"Counting from {from} to {to}:");
        for (int counter = from; counter <= to; counter++)
         {
             //loop-body
            Console.WriteLine(counter);
         }
    }
    else //Do this if the number "to" smaller than number "from"
    {
        Console.WriteLine($"Counting from {from} to {to}:");
        for (int counter = from; counter >= to; counter--)
        {
            //loop-body
            Console.WriteLine(counter); 
        }
    }
}

//initial-statement = int counter = from;
// condition-statement = counter <= or counter >=
//loop-body = Do the things inside the loop, in this case write out int "counter"
// iteration-statement = Do things before checking the condition statement again, in this case if counter is smaller/bigger or equal to int "to". 
