using System;
using System.Collections.Generic;

namespace BT1.Model
{
    public class Sheep : Animal
    {
        public Sheep() : base()
        {
            this.AnimalType = AnimalType.Sheep;
            this.Sound = "Bebe";
        }
        public Sheep(Guid id) : base(id)
        {
            this.AnimalType = AnimalType.Sheep;
        }

        public override List<Animal> GiveBirth()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int num = rnd.Next(0, 10);
            List<Animal> children = new List<Animal>();
            for (int i = 0; i < num; i++)
            {
                children.Add(new Sheep());
            }
            return children;
        }
        

        public override int ProduceMilk()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, 5);
        }
    }
}