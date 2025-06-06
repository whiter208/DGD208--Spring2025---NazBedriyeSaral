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
        Console.WriteLine("Press enter to start!");
        Console.WriteLine("Naz Bedriye Saral 225040061 and our lord and savior ChatGPT.");
        Console.ReadLine();

    }

    private string GetUserInput()
    {
        Console.WriteLine("1 - Pet Adoptation");
        Console.WriteLine("2 - Pet Showcase");
        Console.WriteLine("3 - Use items on Pet");
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
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (choice == "3")
        {
            await UseItemOnPetAsync(); // <- here!
            
        }
        else if (choice == "4")
        {
            _isRunning = false;
        }
    }
    private async Task UseItemOnPetAsync()
    {
        if (petsScript.currentPets.Count == 0)
        {
            Console.WriteLine("No pets available to use items on.");
            Console.WriteLine("Press enter to return to Tamagochi.");
            Console.ReadKey();
            return;
        }

        // 1. Select a Pet
        var petMenu = new Menu<Pet>(
            "Choose a Pet",
            petsScript.currentPets,
            pet => pet.ShowStats()

        );
        Console.ForegroundColor = ConsoleColor.White;


        if (!petMenu.TryShowAndGetSelection(out Pet selectedPet))
            return;

        // 2. Filter compatible items
        var compatibleItems = ItemDatabase.AllItems
            .Where(item => item.CompatibleWith.Contains(selectedPet.GetPetType()))
            .ToList();

        if (compatibleItems.Count == 0)
        {
            Console.WriteLine("No compatible items found for this pet.");
            Console.ReadKey();
            return;
        }

        // 3. Select an Item
        var itemMenu = new Menu<Item>(
            $"Choose an item for your {selectedPet.GetPetType()}",
            compatibleItems,
            item => $"{item.Name} - {item.Type}, {item.AffectedStat} -> {item.EffectAmount} , {item.Duration}s"
        );

        if (!itemMenu.TryShowAndGetSelection(out Item chosenItem))
            return;

        // 4. Use the Item
        await selectedPet.UseItemAsync(chosenItem);

        Console.WriteLine("Press enter to return to main menu...");
        Console.ReadKey();
    }

}
