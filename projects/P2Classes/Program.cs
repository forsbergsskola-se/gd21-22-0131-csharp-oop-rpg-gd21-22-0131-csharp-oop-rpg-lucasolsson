
// Person myPerson = new Person();
// Animal myAnimal = new Animal();
// Car myCar = new Car();
//
// // This calls the different-methods in the classes on the instance
// myPerson.person();
// myAnimal.animal();
// myCar.car();

//Calls out the method in class Person
Person person = new Person();
person.IntroduceYourself();

public class Person
{
    public string name;
    string[] persons = new string[3];
  
    public void IntroduceYourself() //Instance method
    {
        for(var name = 0; name < persons.Length; name++)
        { 
            //Prints and wants input 3 times and stores the input in array "persons"
            Console.WriteLine("Give me a name.");
            persons[name] = Console.ReadLine();
        }

        foreach (string value in persons)
        {
            Console.WriteLine($"Hello, my name is {value}");
        }
    }
    
}
public class Animal
{
    public void animal()
    {
        Console.WriteLine("Animal");
    }
}
public class Car
{
    public void car()
    {
        Console.WriteLine("Car");
    }
}