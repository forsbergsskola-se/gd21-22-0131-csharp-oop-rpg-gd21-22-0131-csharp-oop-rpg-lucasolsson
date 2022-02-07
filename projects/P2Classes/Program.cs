
Person myPerson = new Person();
Animal myAnimal = new Animal();
Car myCar = new Car();

myPerson.person();
myAnimal.animal();
myCar.car();

public class Person
{
    public void person()
    {
        Console.WriteLine("Person");
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