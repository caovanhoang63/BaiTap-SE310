using System;
using System.Collections.Generic;
using System.Linq;
using BT1.Model;
using BT1.Repo;

namespace BT1.Biz
{
    public class FarmBiz
    {
        private readonly IAnimalRepo _repo;
        public List<Animal> Animals { get; private set; }
        public int Cow { get; private set; }
        public int Sheep { get; private set; }
        public int Goat { get; private set; }
        public int Milk { get; private set; }
        public FarmBiz(IAnimalRepo repo)
        {
            _repo = repo; 
            Animals = _repo.GetAllAnimals();
            _updateAnimalCount();
            Milk = repo.GetMilk();
        }

        private void _updateAnimalCount()
        {
            Cow = 0;
            Sheep = 0;
            Goat = 0;
            foreach (var animal in Animals)
            {
                switch (animal.AnimalType)
                {
                    case AnimalType.Cow:
                        Cow++;
                        break;
                    case AnimalType.Goat:
                        Goat++;
                        break;
                    case AnimalType.Sheep:
                        Sheep++;
                        break;
                }
            }
        }
        public void AddAnimal(int cow, int sheep, int goat)
        {
            var newAnimals = new List<Animal>();

            for (int i = 0; i < cow; i++)
            {
                newAnimals.Add(new Cow());
                Cow++;
            }

            for (int i = 0; i < sheep; i++)
            {
                newAnimals.Add(new Sheep());
                Sheep++;
            }

            for (int i = 0; i < goat; i++)
            {
                newAnimals.Add(new Goat());
                Goat++;
            }
            
            _repo.AddAnimals(newAnimals);
            // Update the Animals property
            Animals = _repo.GetAllAnimals();
        }

        public void GiveBirth()
        {
            var children = new List<Animal>();
            foreach (var t in Animals)
            {
                children.AddRange(t.GiveBirth());
            }
            _repo.AddAnimals(children);
            Console.WriteLine(children.Count);
            Animals.AddRange(children);
            Console.WriteLine(Animals.Count);
            _updateAnimalCount();
        }

        public int  GetMilk()
        {
            int total = 0;
            foreach (var animal in Animals)
            {
                total += animal.ProduceMilk();
            }
            _repo.ProduceMilk(total);
            this.Milk += total;
            return total;
        }
    }
}