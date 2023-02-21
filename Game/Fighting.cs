namespace Game;

static class Fighting
{
    public static bool FightingCurrently;
    
    public static void InCombat(Monster monster)
    {
        FightingCurrently = true;

        while (FightingCurrently)
        {
            Console.WriteLine($"\nYou stand face to face with a {monster.Name}");
            Encounter(monster);
            if (Program.Player.CurrentHitPoints <= 0)
            {
                FightingCurrently = false;
            }
            Console.WriteLine("\nDo you wish to continue fighting\n1)yes\n2)no");
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
            Thread.Sleep(2000);
            
            if (monster.CurrentHitPoints <= 0)
            {
                Console.WriteLine($"\nYou deal {dealt} damage, killing the {monster.Name}");
                Item drop = monster.Loot.Items[World.RandomGenerator.Next(0, monster.Loot.Items.Count)].Item;
                Thread.Sleep(1000);
                Console.WriteLine($"\nit dropped a {drop.Name}");
                player.Inventory.Items.AddItem(drop);
                break;
            }
            
            Console.WriteLine($"\nYou deal {dealt} damage to the {monster.Name}, they have {monster.CurrentHitPoints} Hp left");
            Thread.Sleep(2000);
            int received = monster.CurrentHitPoints;
            player.CurrentHitPoints -= received;
            
            if (player.CurrentHitPoints <= 0)
            {
                Console.WriteLine($"\nYou received {received} damage and were defeated by the {monster.Name}, you're dead");
                break;
            }
            
            Console.WriteLine($"\nThe {monster.Name} deals {received} damage, you have {player.CurrentHitPoints} Hp left ");
            Thread.Sleep(2000);
        }
    }
}