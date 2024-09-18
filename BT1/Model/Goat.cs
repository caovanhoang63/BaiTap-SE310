using System;

namespace BT1.Model
{
    public class Goat : Animal
    {
        public Goat()
        {
            this.AnimalType = AnimalType.Goat;
            this.Sound = "Be";
            this.Id = Guid.NewGuid().GetHashCode();
        }
        
        public override string MakeSound()
        {
            return this.Sound;
        }

        public override Animal GiveBirth()
        {
            return new Goat();
        }
        

        public override int ProduceMilk()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, 10);
        }
    }
}