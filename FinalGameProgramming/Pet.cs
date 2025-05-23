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
            return $" ({type}) - Hunger: {hunger}, Sleep: {sleep}, Fun: {fun}";
        }

       public void ChangeStats()
        {
            Console.WriteLine("stats have changed");
            hunger++;
            sleep++;
            fun--;
            if (hunger > 100 && sleep > 100 && fun <= 0)
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
    }
}
