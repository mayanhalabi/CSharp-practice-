Babydog babydog = new Babydog();
babydog.crying();
babydog.brak();
babydog.eat();

// Dog dog = new Dog();
// dog.eat();
// dog.brak();



public class Animal
{
    public void eat()
    {
        Console.WriteLine("eating...");
    }
}
public class Dog : Animal
{
    public void brak()
    {
        Console.WriteLine("braking ...");
    }
}
public class Babydog : Dog 

{
    public void crying()
    {
        Console.WriteLine("crying ...");
    }
}