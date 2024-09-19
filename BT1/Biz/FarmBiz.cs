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
        public FarmBiz(IAnimalRepo repo)
        {
            _repo = repo; 
            Animals = _repo.GetAllAnimals();
        }

        public void AddAnimal(int cow, int sheep, int goat)
        {
            var newAnimals = new List<Animal>();

            for (int i = 0; i < cow; i++)
            {
                newAnimals.Add(new Cow());
            }

            for (int i = 0; i < sheep; i++)
            {
                newAnimals.Add(new Sheep());
            }

            for (int i = 0; i < goat; i++)
            {
                newAnimals.Add(new Goat());
            }
            
            
            _repo.AddAnimals(newAnimals);
            // Update the Animals property
            Animals = _repo.GetAllAnimals();
        }

        public void GiveBirth()
        {
            var children = new List<Animal>();
            foreach (var t in Animals) children.AddRange(t.GiveBirth());
            Animals.AddRange(children);
            _repo.AddAnimals(children);
        }

        public void GetMilk()
        {
            int total = 0;
            foreach (var animal in Animals)
            {
                total += animal.ProduceMilk();
            }
            _repo.GetMilk(total);
        }
    }
}