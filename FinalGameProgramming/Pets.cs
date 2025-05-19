using System;
using System.Collections.Generic;

namespace FinalGameProgramming
{
    internal class Pets
    {
        public List<Pet> currentPets = new List<Pet>();

        public void CreatePet(PetType _petType)
        {
            Pet pet = new Pet();
            pet.PetStart(_petType);
            currentPets.Add(pet);


        }

        public void ShowCaseCurrentPets()
        {
            for (int i = 0; i < currentPets.Count; i++)
            {
                Console.WriteLine(currentPets[i].ShowStats());
            }
        }


    }
}
