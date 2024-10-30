namespace DogsMVC.Models;

public class DataService
{
        List<Dog>dogs = [


        new Dog (1, "Ruffs", 5),
        new Dog (2, "Mindy", 2),
        new Dog (3, "Tindra", 8),
        ];


        public void AddDog(Dog dog)
        {
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
}


