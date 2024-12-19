namespace BattleRoyalGame
{
    public abstract class Utility
    {
        public abstract void PrintValues(string value, string[] array);
    }

    public class ConsoleUtility : Utility
    {

        public string[] races = { "Orcs", "Dwarves", "Elves", "Undead", "Human" };

        public string[] classes =
    {
        "Assassin (A stealthy and agile character [Unique Skill: Wall Walk])",
        "Mage (Master of the Arcane [Unique Skill: Mana capacity 200%])",
        "Tank (Heavily Armored Defender [Unique Skill: Heavy Shield])",
        "Ranger (Master of the Hunt [Unique Skill: Bow Rapid Fire])",
        "Marksman (Precision shooter [Unique Skill: Damage Dealt Over 50 meters is Doubled])",
        "Swordsman (Melee fighter that specializes in swordplay [Unique Skill: Deflect Incoming Projectile Using Your Sword])",
        "Monk (Prioritizes Team Buff [Unique Skill: Karma, inflict a random debuff to the enemy])",
        "Lancer (Polearm expert [Unique Skill: CHARGE!!!!])"
    };

        public string[] weapons =
    {
        "Daggers (Short, dual-wielded blades ideal for quick, close-range attacks and stealth tactics [Assassin Bonus: Attack Speed +20%])",
        "Wand (A magical tool that is used to shoot magic [Mage Bonus: Casting Speed +20%])",
        "Shields (Defensive equipment used to block incoming attacks and can be used in offense [Tank Bonus: Defense +20%])",
        "Bow (A ranged weapon requiring skill and accuracy to launch arrows at distant targets [Ranger Bonus: Accuracy +20%])",
        "Rifle (A long-range firearm designed for precision shooting and high damage from a distance [Marksman Bonus: Attack +20%])",
        "Long Sword (A versatile melee weapon with a balance of reach and power, suited for close combat [Swordsman Bonus: Ranged Enemy Damage +20%])",
        "Fist (Unarmed combat relying on brute strength and martial arts expertise [Monk Bonus: Heal +20%])",
        "Lance (A long polearm designed for thrusting attacks, offering great reach and power, commonly used in mounted combat [Lancer Bonus: Mounted Damage +20%])"
    };

        public string[] weaponCosmetics = { "Rusty", "Glowing", "Enchanted", "Flaming", "Diamond Coated" };

        public string[] skills =
    {
        "Movement_Speed_Buff (Temporarily increases a character's speed, allowing for quicker repositioning or escape [Cooldown: 1 minute])",
        "Attack_Buff (Enhances attack power, dealing more damage to enemies for a short duration [Cooldown: 2 minutes])",
        "Defense_Buff (Boosts defense, reducing incoming damage [Cooldown: 2 minutes])",
        "Recon (Scans and reveal enemies within 30-meter radius [Cooldown: 5 minutes])",
        "Invisibility (Grants temporary invisibility [Cooldown: 5 minutes])",
        "Teleportation (Instantly transports the character to a chosen location within 30-meters [Cooldown: 7 minutes])"
    };

        public string[] utilities =
    {
        "Smoke_Bomb (Creates a cloud of smoke to obscure vision and escape from enemies [Cooldown: 2 minutes])",
        "Shuriken (A throwable, sharp weapon that deals minor damage [Cooldown: 30 seconds])",
        "Health_Potion (Restores a portion of the character's health instantly upon use [Cooldown: 1 minute])",
        "Mana_Potion (Replenishes a character's mana, enabling continued use of skills [Cooldown: 1 minute])",
        "Molotov (A throwable incendiary weapon that creates a fire area, damaging enemies over time [Cooldown: 3 minutes])"
    };

        public string[] armorTypes =
    {
        "Heavy (Provides maximum protection with thick, durable plating, but limits mobility)",
        "Medium (Offers a balanced mix of defense and mobility, suitable for versatile combat)",
        "Light (Lightweight armor that allows for agility and speed, but offers less protection)",
        "Leather (Flexible and durable armor made from tanned hides, providing moderate protection and agility)",
        "Wizard_Robe (A magical robe designed for spellcasters, offering minimal physical protection but enhancing magical abilities)"
    };

        public string[] armorBattleDamage = { "True", "False" };

        public string[] physique = { "Slim", "Lean", "Fit", "Balanced", "Muscular", "Bulky" };

        public string[] height = { "Short", "Below Average", "Average", "Above Average", "Tall" };

        public string[] skinComplexities = { "Pale", "Brown", "Dark", "Freckled", "Crimson Red", "Mystic Blue", "Goblin Green" };

        public string[] hairStyles =
    {
        "Short", "Medium", "Long", "Curly", "Afro", "Bald",
        "Wavy", "Pixie Cut", "Ponytail", "Braid", "Mullet", "Mohawk"
    };

        public string[] hairColors =
    {
        "Black", "Brown", "Blonde", "Red", "White",
        "Silver", "Gray", "Blue", "Green", "Purple",
        "Pink", "Violet", "Orange"
    };

        public string[] eyeColors =
    {
        "Black", "Brown", "Blue", "Green", "Gray",
        "Yellow", "Red", "Silver", "Orange"
    };

        public string[] headwear =
    {
        "Floral Crown", "Golden Crown", "Thorn Crown",
        "Cat Ears", "Bunny Ears", "Wizard Hat",
        "Cowl", "Halo"
    };

        public string[] backAccessories =
    {
        "Cape", "Angel Wings", "Demon Wings", "Quiver",
        "Scabbard", "Banner", "Backpack", "Guitar", "Coffin"
    };

        public string[] tattoos =
    {
        "Tribal Arm Tattoo", "Serpent Neck Tattoo",
        "Angel Wings Back Tattoo", "Tear Drop Face Tattoo",
        "Floral Leg Tattoo", "Rose Ankle Tattoo"
    };

        public string[] mounts =
    {
        "Armored Warhorse", "Frost Drake", "Shadow Panther",
        "Fiery War steed", "Mechano-Raptor", "Spectral Phoenix",
        "Thunder Mammoth", "Emerald Stag"
    };

        public string[] pets =
    {
        "Baby Dragon", "Spirit Fox", "Voidling",
        "Battle Pup", "Winter Wolf"
    };

        public string[] lobbyAnimations =
    {
        "Idle Stance", "Ready Stance", "Relaxed Stance",
        "Victory Pose", "Sleepy Stance"
    };

        public string[] deathAnimations =
    {
        "Vaporization", "Frozen in Ice", "Orbital Lazer",
        "Rocket Boom", "Lightning Strike", "Explosion",
        "Soul Escape"
    };
        public string[] stats = { "Weapon Damage ", "Weapon Range ", "Weapon Critical Damage", "Weapon Critical Change",
            "Weapon Ammo", "Weapon Reload Speed", "Accuracy", "Luck", "Inventory Capacity" };

        public string[] menu = { "NEW GAME", "LOAD GAME", "CAMPAIGN MODE", "CREDITS", "EXIT" };


        public override void PrintValues(string prompt, string[] array)
        {

            Console.Clear();
            Console.WriteLine(prompt);
            int i = 0;

            foreach (string value in array)
            {

                Console.WriteLine("[" + i++ + "] " + value);
            }

        }

        public static void TypeWriterEffect(string text, int delay = 25)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public void CsvReader(string filepath)
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            var lines = File.ReadAllLines(filepath);
            var headers = lines[0].Split(',');

            Console.Write("ID".PadRight(20));
            
            int a = 0;
            for (int j = 1; j < lines.Length; j++)
            {
                Console.Write(" | ");
                Console.Write(a.ToString().PadRight(20));
                a++;
            }

            Console.WriteLine();



            for (int i = 0; i < headers.Length; i++)
            {

                Console.Write(headers[i].PadRight(20));
             
                if (lines.Length == 1)
                {
                    Console.Write(" | ");
                    Console.WriteLine();
                  
                }
                else
                {
                    for (int j = 1; j < lines.Length; j++)
                    {
                        Console.Write(" | ");
                        var fields = lines[j].Split(',');
                        Console.Write(fields[i].PadRight(20));
                    }
                    Console.WriteLine();
                }

            
            }
        

        }

        public void CsvDeleter (string filepath)
        {
            try
            {
                var lines = File.ReadAllLines(filepath).ToList();


                if (lines.Count == 1)
                {
                    Console.WriteLine("There is no character to be deleted");

                }
                else
                {
                    int index = Convert.ToInt32(Console.ReadLine());

                    if (index < 0 || index + 1 >= lines.Count )
                    {
                        Console.WriteLine("Invalid input");

                    }
                    else
                    {
                        lines.RemoveAt(index + 1);
                        File.WriteAllLines(filepath, lines);
                    }
                }
            }

            
            catch (FormatException) {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
            }
        }

    }
}
