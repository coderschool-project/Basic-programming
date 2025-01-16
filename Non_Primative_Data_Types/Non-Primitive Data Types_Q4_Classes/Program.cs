//---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */

class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int HealthPoints { get; set; }
    public int ExperiencePoints { get; set; }

    public void LevelUp()
    {
        Level++;
        HealthPoints += 10;
        ExperiencePoints += 10;
    }

    public void Heal()
    {
        HealthPoints += 10;
    }

    public void GainExperience()
    {
        ExperiencePoints += 10;
    }
}

//---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */

class Enemy
{
    public string Name { get; set; }
    public int HealthPoints { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public int CalculateDamage(int playerAttackPower)
    {
        return playerAttackPower - Defense;
    }

    public void UpdateHealth(int damage)
    {
        HealthPoints -= damage;
    }
}

//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */

class Potion
{
    public string Name { get; set; }
    public int HealingPower { get; set; }
    public int Quantity { get; set; }

    public void ApplyPotion(Player player)
    {
        player.Heal();
    }
}
//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */

class Quest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Reward { get; set; }
    public bool Completed { get; set; }

    public void StartQuest()
    {
        Completed = true;
    }

    public void CompleteQuest()
    {
        Completed = true;
    }

    public void ClaimReward()
    {
        Console.WriteLine("You have claimed the reward!");
    }
}

//---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */

class Inventory
{
    public int Capacity { get; set; }
    public List<Item> Items { get; set; }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public bool ItemExists(Item item)
    {
        return Items.Contains(item);
    }

    public void DisplayItemDetails(Item item)
    {
        Console.WriteLine(item.Name);
        Console.WriteLine(item.Description);
        Console.WriteLine(item.Quantity);
    }
}

//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */

class Spell
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int ManaCost { get; set; }
    public string Description { get; set; }

    public void CastSpell(Player player)
    {
        player.Heal();
    }

    public void ConsumeMana(Player player)
    {
        player.ManaPoints -= ManaCost;
    }

    public void DisplaySpellDetails()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Damage);
        Console.WriteLine(ManaCost);
        Console.WriteLine(Description);
    }
}