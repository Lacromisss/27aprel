using System;

namespace _30Mart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm()
            {
                SheepLimit = 5,
                HorseLimit = 9,
            };
            Sheep sh1 = new Sheep();
            Sheep sh2 = new Sheep();
            Sheep sh3 = new Sheep();
            Sheep sh4 = new Sheep();
            Sheep sh5 = new Sheep();
            Sheep sh6 = new Sheep();
            Sheep sh7 = new Sheep();
            Sheep sh8 = new Sheep();
            Horse hr1 = new Horse();
            Horse hr2 = new Horse();
            Horse hr3 = new Horse();
            Horse hr4 = new Horse();
            Horse hr5 = new Horse();
            Horse hr6 = new Horse();
            Horse hr7 = new Horse();
            Horse hr8 = new Horse();
            Sheep[] sheeps = {sh1,sh2,sh3,sh4,sh5,sh6,sh7,sh8};
            Horse[] horses = {hr1,hr2,hr3,hr4,hr5,hr6,hr7,hr8};
            
            try
            {
                foreach (var item in sheeps)
                {
                    farm.AddAnimal(item);
                }
                foreach (var item in horses)
                {
                    farm.AddAnimal(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
