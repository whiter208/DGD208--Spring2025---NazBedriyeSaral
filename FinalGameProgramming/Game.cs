using FinalGameProgramming;

public class Game
{
    private bool _isRunning;

    Pets petsScript = new Pets();

    public async Task GameLoop()
    {
        // Initialize the game
        Initialize();

        // Main game loop
        _isRunning = true;
        while (_isRunning)
        {
            // Display menu and get player input
            string userChoice = GetUserInput();

            // Process the player's choice
            await ProcessUserChoice(userChoice);
        }

        Console.WriteLine("Thanks for playing!");
    }

    private void Initialize()
    {
        Console.WriteLine("Press to start!");
        Console.WriteLine("Naz Bedriye Saral 225040061");
        Console.ReadLine();

    }

    private string GetUserInput()
    {
        Console.WriteLine("1 - Pet Adoptation");
        Console.WriteLine("2 - Pet Showcase");
        Console.WriteLine("3 - Pet Room");
        Console.WriteLine("4 - Quit Game");

        string userInput = Console.ReadLine();
        return userInput;
    }

    private async Task ProcessUserChoice(string choice)
    {
        if (choice == "1")
        {
            List<PetType> petTypes = Enum.GetValues(typeof(PetType)).Cast<PetType>().ToList();
            var petMenu = new Menu<PetType>("Select an pet to adopt.", petTypes, pet => pet.ToString());
            PetType selectedPet;
            if (petMenu.TryShowAndGetSelection(out PetType _selectedPetType))
            {
                selectedPet = _selectedPetType;
                petsScript.CreatePet(selectedPet);
            }


        }
        else if (choice == "2")
        {
            petsScript.ShowCaseCurrentPets();
        }
        else if (choice == "3")
        {

        }
        else if (choice == "4")
        {
            _isRunning = false;
        }
    }
}
