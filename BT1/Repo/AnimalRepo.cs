using System.Collections.Generic;
using BT1.Model;

namespace BT1.Repo
{
    public interface IAnimalRepo
    {
        void GetMilk(int l);
        void AddAnimals(List<Animal> animals);
        List<Animal> GetAllAnimals();
        void AddAnimal(Animal animal);
    }
    
}