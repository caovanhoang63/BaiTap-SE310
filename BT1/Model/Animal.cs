using System;

namespace BT1.Model
{
    public abstract class Animal
    {
        protected Animal()
        {
            this.Id = Guid.NewGuid().GetHashCode();
        }
        public AnimalType AnimalType { get; protected set; }
        public int Id { get; protected set; }
        protected string Sound { get; set; }
        public abstract string MakeSound();
        public abstract Animal GiveBirth();
        public abstract int ProduceMilk();
    }
}