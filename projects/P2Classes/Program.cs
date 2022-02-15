
public class Person
{
    //Its like a variable that belongs to each instance of the class
    public string name; //abstract: PROPERTY of the class (what it IS or HAS)

    public void IntroduceYourself()
    {
        Console.WriteLine($"Hello, my name is {name}");
    }

    static void Main()
    {
        Person[] persons = new Person[3];
        
        for(int i = 0; i < persons.Length; i++)
        { 
            //Prints and wants input 3 times and stores the input in array "persons"
            Person newFriend = new Person();
            Console.WriteLine("Give me a name.");
            newFriend.name = Console.ReadLine();
            persons[i] = newFriend;
        }

        foreach (Person friend in persons)
        {
            friend.IntroduceYourself();
        }
    }
    
}
// public class Animal
// {
//     public void animal()
//     {
//         Console.WriteLine("Animal");
//     }
// }
// public class Car
// {
//     public void car()
//     {
//         Console.WriteLine("Car");
//     }
// }