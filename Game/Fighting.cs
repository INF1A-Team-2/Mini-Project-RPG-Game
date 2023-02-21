namespace Game;

static class Fighting
{
    public static bool FightingCurrently;
    
    public static void InCombat(Monster monster)
    {
        FightingCurrently = true;

        while (FightingCurrently)
        {
            Console.WriteLine($"You stand face to face with a {monster.Name}");
            Encounter(monster);
            if (Program.Player.CurrentHitPoints <= 0)
            {
                FightingCurrently = false;
            }
            Console.WriteLine("Do you wish to continue fighting\n1)yes\n2)no");
            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    FightingCurrently = false;
                    break;
                default:
                    FightingCurrently = false;
                    break;
            }
        }
        
        
        
    }

    static void Encounter(Monster monster)
    {
        Player player = Program.Player;
        
        while (true)
        {
            int dealt = World.RandomGenerator.Next(player.CurrentWeapon.MinimumDamage, player.CurrentWeapon.MaximumDamage);
            
            monster.CurrentHitPoints -= dealt;
            
            if (monster.CurrentHitPoints <= 0)
            {
                Console.WriteLine($"You deal {dealt} damage and defeat the {monster.Name}");
                Item drop = monster.Loot.Items[World.RandomGenerator.Next(0, monster.Loot.Items.Count)].Item;
                Console.WriteLine($"it dropped {drop.Name}");
                player.Inventory.Items.AddItem(drop);
                break;
            }
            
            Console.WriteLine($"You deal {dealt} damage to the {monster.Name}, they have {monster.CurrentHitPoints} Hp left");

            int received = monster.CurrentHitPoints;
            player.CurrentHitPoints -= received;
            
            if (player.CurrentHitPoints <= 0)
            {
                Console.WriteLine($"You received {received} damage and were defeated by the {monster.Name}, you're dead");
                break;
            }
            
            Console.WriteLine($"The {monster.Name} deals {received} damage, you have {player.CurrentHitPoints} Hp left ");
        }
    }
}