using System;

namespace BT1.Model
{
    public class Cow : Animal
    {
        public Cow()
        {
            this.AnimalType = AnimalType.Cow;
            this.Sound = "Moooo";
        }
        
        public override string MakeSound()
        {
            return this.Sound;
        }

        public override Animal GiveBirth()
        {
            return new Cow();
        }
        

        public override int ProduceMilk()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(0, 20);
        }
    }
}