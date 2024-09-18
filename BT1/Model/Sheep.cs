using System;

namespace BT1.Model
{
    public class Sheep : Animal
    {
        public Sheep()
        {
            this.AnimalType = AnimalType.Sheep;
            this.Sound = "Bebe";
            this.Id = Guid.NewGuid().GetHashCode();
        }
        
        public override string MakeSound()
        {
            return this.Sound;
        }

        public override Animal GiveBirth()
        {
            return new Sheep();
        }
        

        public override int ProduceMilk()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, 5);
        }
    }
}