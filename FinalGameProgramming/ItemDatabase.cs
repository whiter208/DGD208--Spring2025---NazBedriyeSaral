public static class ItemDatabase
{
    public static List<Item> AllItems = new List<Item>
    {
        // Foods
        new Item {
            Name = "Honey",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Bear },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -15,
            Duration = 2.5f  // Takes 2.5 seconds to eat
        },
        new Item {
            Name = "Fish",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Bear },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -30,
            Duration = 3.0f  // Takes 3 seconds to eat
        },
        new Item {
            Name = "Rabbit",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Lynx },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -15,
            Duration = 2.0f
        },
        new Item {
            Name = "Duck",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Lynx },
            AffectedStat = PetStat.Hunger,
            EffectAmount =- 25,
            Duration = 1.5f  // Quick treat
        },
        new Item {
            Name = "Bird Seed",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Raven },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -10,
            Duration = 1.0f
        },
        new Item {
            Name = "Fruit Mix",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Raven },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -20,
            Duration = 2.0f
        },
        new Item {
            Name = "Worm",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Axolotl },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -10,
            Duration = 0.5f  // Very quick to consume
        },
        new Item {
            Name = "Shrimp",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Axolotl },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -20,
            Duration = 1.0f
        },
        new Item {
            Name = "Flowers",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -15,
            Duration = 3.0f  // Takes time to chew
        },
        new Item {
            Name = "Leafy Greens",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -25,
            Duration = 4.0f  // Lots to munch through
        },
        
        // Universal Foods
        new Item {
            Name = "Vitamin Treat",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Bear, PetType.Lynx, PetType.Deer },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -10,
            Duration = 1.0f  // Quick treat
        },
        new Item {
            Name = "Gourmet Dinner",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Bear, PetType.Lynx },
            AffectedStat = PetStat.Hunger,
            EffectAmount = -40,
            Duration = 5.0f  // Fancy meal takes time
        },
        
        // Toys
        new Item {
            Name = "Football",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Bear },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 4.0f  // Playing fetch takes time
        },
        new Item {
            Name = "Log",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Bear },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 2.5f
        },
        new Item {
            Name = "Scratching Board",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Lynx },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 3.0f  // Playing with string
        },
        new Item {
            Name = "Toy Mouse",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Lynx },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 2.0f
        },
        new Item {
            Name = "Swing",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Raven },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 3.0f  // Swinging
        },
        new Item {
            Name = "Bell",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Raven },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.5f
        },
        new Item {
            Name = "Bubbler",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Axolotl },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 2.0f  // Watching bubbles
        },
        new Item {
            Name = "Water Plant",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Axolotl },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 1.5f
        },
        new Item {
            Name = "Another Deer",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 3.5f  // Lots of chewing
        },
        new Item {
            Name = "Train",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 4.0f  // Running through tunnels
        },
        
        // Universal Toys
        new Item {
            Name = "Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Bear, PetType.Lynx, PetType.Deer },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 2.0f
        },
        
        // Sleep Items
        new Item {
            Name = "Comfy Bed",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Bear, PetType.Lynx },
            AffectedStat = PetStat.Sleep,
            EffectAmount = -30,
            Duration = 6.0f  // Takes time to fall asleep
        },
        new Item {
            Name = "Pet Blanket",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Bear, PetType.Lynx, PetType.Deer },
            AffectedStat = PetStat.Sleep,
            EffectAmount = -20,
            Duration = 4.0f
        },
        new Item {
            Name = "Perch",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Raven },
            AffectedStat = PetStat.Sleep,
            EffectAmount = -25,
            Duration = 3.0f
        },
        new Item {
            Name = "Cave Decoration",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Axolotl },
            AffectedStat = PetStat.Sleep,
            EffectAmount = -15,
            Duration = 2.0f
        },
        new Item {
            Name = "Hideaway",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Deer },
            AffectedStat = PetStat.Sleep,
            EffectAmount = -25,
            Duration = 5.0f  // Takes time to get comfortable
        }
    };
}
