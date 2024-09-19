using System;
using System.Collections.Generic;

namespace BT1.Model
{
    public class Goat : Animal
    {
        public Goat() :base()
        {
            this.AnimalType = AnimalType.Goat;
            this.Sound = "Be";
        }
        public Goat(Guid id) : base(id)
        {
            this.AnimalType = AnimalType.Goat;
        }

 

        public override List<Animal> GiveBirth()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int num = rnd.Next(0, 10);
            List<Animal> children = new List<Animal>();
            for (int i = 0; i < num; i++)
            {
                children.Add(new Goat());
            }
            return children;
        }

        public override int ProduceMilk()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, 10);
        }
    }
}