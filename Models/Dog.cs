namespace DogsMVC.Models;

public class Dog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Dog()
    {
        
    }

    public Dog(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
