using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BT1.Model
{
    public abstract class Animal
    {
        protected Animal()
        {
            this.Id = Guid.NewGuid();
        }

        protected Animal(Guid id)
        {
            this.Id = id;
        }
        
        public AnimalType AnimalType { get; protected set; }
        public Guid Id { get; protected set; }
        protected string Sound { get; set; }

        public  void MakeSound()
        {
            Debug.WriteLine(this.Sound);
        }
        public abstract List<Animal> GiveBirth();
        public abstract int ProduceMilk();
    }
}