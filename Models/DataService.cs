
namespace DogsMVC.Models;

public class DataService
{
    List<Dog> dogs = [


    new Dog (1, "Ruffs", 5),
        new Dog (2, "Mindy", 2),
        new Dog (3, "Tindra", 8),
        new Dog (4, "Lofsen", 1),
        new Dog (5, "Sengin", 12),
        new Dog (6, "Lady", 5),
        ];


    public void AddDog(Dog dog)
    {
        dog.Id = dogs.Max(d => d.Id) + 1;
        dogs.Add(dog);
    }

    public List<Dog> GetAllDogs()
    {
        return dogs.ToList();
    }

    public Dog GetDogById(int id)
    {
        var ret = dogs.FirstOrDefault(o => o.Id == id);
        return ret;
    }

    internal void UpdateDog(Dog dog)
    {
        var dogInList = dogs.FirstOrDefault(o => o.Id == dog.Id);
        dogInList.Name = dog.Name;
        dogInList.Age = dog.Age;
    }
}


