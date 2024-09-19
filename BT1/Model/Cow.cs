using System;
using System.Collections.Generic;

namespace BT1.Model
{
    public class Cow : Animal
    {
        public Cow() : base()
        {
            this.AnimalType = AnimalType.Cow;
            this.Sound = "Moooo";
        }

        public Cow(Guid id) : base(id)
        {
            this.AnimalType = AnimalType.Cow;
        }
        public override List<Animal> GiveBirth()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int num = rnd.Next(0, 2);
            List<Animal> children = new List<Animal>();
            for (int i = 0; i < num; i++)
            {
                children.Add(new Cow());
            }
            return children;
        }
        

        public override int ProduceMilk()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, 20);
        }
    }
}