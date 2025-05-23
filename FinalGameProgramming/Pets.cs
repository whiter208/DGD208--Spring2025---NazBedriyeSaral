using System;
using System.Collections.Generic;
using System.Timers;

namespace FinalGameProgramming
{
    internal class Pets
    {
        public List<Pet> currentPets = new List<Pet>();

        private System.Timers.Timer timer;

        public event EventHandler OnTick;

        public Pets()
        {
            timer = new System.Timers.Timer(1000); // 1000ms = 1 second
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Raise the event every second
            OnTick?.Invoke(this, EventArgs.Empty);
        }
        public void CreatePet(PetType _petType)
        {
            Pet pet = new Pet();
            pet.PetStart(_petType);
            currentPets.Add(pet);
            OnTick += pet.OnTick;
            pet.manager = this;


        }
        public void RemovePet(Pet _pet)
        {
            OnTick -= _pet.OnTick;
            currentPets.Remove(_pet);


            Console.WriteLine($"Pet of type removed from system.");
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
