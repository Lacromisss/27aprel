using System;
using System.Collections.Generic;
using System.Text;

namespace _30Mart1
{
    internal class Farm
    {
        private Animal[] _animals;
        public Farm()
        {
            this._animals = new Animal[0];
        }
        public Animal[] Animals
        {
            get => this._animals;
        }
        public int HorseLimit { get; set; }
        public int SheepLimit { get; set; }
        public void AddAnimal(Animal animal)
        {
            Type sheep = typeof(Sheep);
            Type horse = typeof(Horse);

            int SheepCount = 0;
            int HorseCount = 0;
            foreach (var item in this._animals)
            {
                if (item is Sheep)
                    SheepCount++;
                if (item is Horse)
                    HorseCount++;
            }


            if (this._animals.Length < this.HorseLimit + this.SheepLimit)
            {
                if (animal is Sheep)
                {
                    if (SheepCount < this.SheepLimit)
                    {
                        Array.Resize(ref this._animals, this._animals.Length + 1);
                        this._animals[this._animals.Length - 1] = animal;
                    }
                    else
                    {
                        throw new Exception("Sheep Limiti Asdi");
                    }

                }
                else if(animal is Horse)
                {
                    if (HorseCount < this.HorseLimit)
                    {
                        Array.Resize(ref this._animals, this._animals.Length + 1);
                        this._animals[this._animals.Length - 1] = animal;
                    }
                    else
                    {
                        throw new Exception("Horse Limiti Asdi");
                    }

                } else
                {
                    throw new Exception("Bu heyvan olmaz!");
                }

            }
            else
            {
                throw new Exception("Animal Limiti Asdi");
            }


        }
    }
}
