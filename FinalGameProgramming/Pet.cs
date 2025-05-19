using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGameProgramming
{
    internal class Pet
    {


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
    }
}
