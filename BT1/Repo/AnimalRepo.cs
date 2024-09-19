using System.Collections.Generic;
using BT1.Model;

namespace BT1.Repo
{
    public interface IAnimalRepo
    {
        void ProduceMilk(int l);
        int GetMilk();
        void AddAnimals(List<Animal> animals);
        List<Animal> GetAllAnimals();
        void AddAnimal(Animal animal);
    }
    
}