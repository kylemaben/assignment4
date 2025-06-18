// Declares the first Rarity enum variable as Uncommon
using assignmen4;

Rarity firstRarity = Rarity.Uncommon;
// Declares the second Rarity enum variable as Legendary
Rarity secondRarity = Rarity.Legendary;

// Display the values of both Rarity enums 
System.Console.WriteLine($"First Rarity: {firstRarity}\nSecond Rarity: {secondRarity}\n");

// Create the first instance of the DnDItem class.
DnDItem item1 = new DnDItem();
// Assign the name Potion of Healing to item1.
item1.Name = "Potion of Healing";
// Assign the rarity Common to item1.
item1.ItemRarity = Rarity.Common;
// Assign the weight to item1.
item1.WeightLbs = 0.5;
// Set the magical status of item1 to true.
item1.IsMagical = true;

// Create the second instance of the DnDItem class.
DnDItem item2 = new DnDItem();
// Assign the name Sword of A Thousand Truths to item2.
item2.Name = "Sword of A Thousand Truths";
// Assign the rarity Legendary to item2.
item2.ItemRarity = Rarity.Legendary;
// Assign the weight to item2.
item2.WeightLbs = 4.0;
// Set the magical status of item2 to true.
item2.IsMagical = true;

// Display a header for the first item's details.
System.Console.WriteLine("--- Item 1 Details ---\n" +
                         // Display the name of item1 using its getter.
                         $"Name: {item1.Name}\n" +
                         // Display the rarity of item1 using its getter.
                         $"Rarity: {item1.ItemRarity}\n" +
                         // Display the weight of item1 using its getter.
                         $"Weight: {item1.WeightLbs} lbs\n" +
                         // Display the magical status of item1 using its getter.
                         $"Magical: {item1.IsMagical}\n");

// Display a header for the second item's details.
System.Console.WriteLine("--- Item 2 Details ---\n" +
                         // Display the name of item2 using its getter.
                         $"Name: {item2.Name}\n" +
                         // Display the rarity of item2 using its getter.
                         $"Rarity: {item2.ItemRarity}\n" +
                         // Display the weight of item2 using its getter.
                         $"Weight: {item2.WeightLbs} lbs\n" +
                         // Display the magical status of item2 using its getter.
                         $"Magical: {item2.IsMagical}");
