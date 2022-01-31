//for-loop counting from 1-1000 by increasing with +1 
Console.WriteLine("From 1 to 1000");
for(int i = 1; i <= 1000; i++) 
{
    Console.WriteLine(i);
}

//for-loop counting from 200-100 by decrementing with -1
Console.WriteLine("From 200 to 100");
for(int i = 200; i >= 100; i--)
{
    Console.WriteLine(i);
}

//for-loop dividing i with 2 until reaching 1
Console.WriteLine("From 1024 to 1");
for (int i = 1024; i >= 1; i/=2)
{
    Console.WriteLine(i);
}

//Note, we can use int = i again because the variable is local inside the for-loop