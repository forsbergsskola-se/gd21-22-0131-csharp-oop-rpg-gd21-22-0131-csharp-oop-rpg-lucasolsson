Random random = new Random();
int[] array = new int[11] {0,1,2,3,4,5,6,7,8,9,10};

Console.WriteLine("I will roll 10.000 numbers between 0 and 10");
for (int roll = 0; roll <= 10000; roll++)
{
    int randomNum = random.Next(0, array.Length);
    array[randomNum]++;

}

for (int index = 0; index <= 10; index++) 
{
    Console.WriteLine($"I rolled {index} a total of {array[index]} times");
}