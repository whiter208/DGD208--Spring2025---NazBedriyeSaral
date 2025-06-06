using System;
using System.Collections.Generic;

namespace FinalGameProgramming
{
    internal class Pet
    {
        public Pets manager;

        PetType type;
        int hunger;
        int sleep;
        int fun;

        public void PetStart(PetType _type)
        {
            type = _type;
            hunger = sleep = fun = 50;
        }

        public string ShowStats()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            return $" ({type}) - Hunger: {hunger}, Sleep: {sleep}, Fun: {fun}";
            
        }

       public void ChangeStats()
        {
            //Console.WriteLine("stats have changed");
            hunger++;
            sleep++;
            fun--;
            if (hunger > 100 || sleep > 100 || fun <= 0)
            {
                KillPet();
            }
        }
        public void OnTick(object sender, EventArgs e)
        {
            ChangeStats();
        }
        void KillPet()
        {
            //Should kill the pet  
            manager.RemovePet(this);
        }
        public PetType GetPetType()
        {
            return type;
        }

        public async Task UseItemAsync(Item item)
        {

            Console.WriteLine($"Using {item.Name} on your {type}...");

            await Task.Delay((int)(item.Duration * 1000)); // simulate time delay


            switch (item.AffectedStat)
            {
                case PetStat.Hunger:
                    hunger = Math.Min(100, hunger + item.EffectAmount);
                    break;
                case PetStat.Sleep:
                    sleep = Math.Min(100, sleep + item.EffectAmount);
                    break;
                case PetStat.Fun:
                    fun = Math.Min(1000, fun + item.EffectAmount);
                    break;
            }

            Console.WriteLine($"{item.Name} used successfully!");
            Console.WriteLine("Updated Stats: " + ShowStats());
            Console.ForegroundColor = ConsoleColor.White;

        }

    }


}
