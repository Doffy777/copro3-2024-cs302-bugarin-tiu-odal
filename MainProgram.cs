    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System;

    namespace BattleRoyalGame
    {
        public class MainProgram : ConsoleUtility
        {
            public static void Main(string[] args)
            {

                
                var options = new DbContextOptionsBuilder<BattleroyalDb>()
                    .UseMySql("server=localhost;database=battleroyaldb;user=root;password=122333", 
                        new MySqlServerVersion(new Version(8, 0, 40)))
                    .Options;

                using var context = new BattleroyalDb(options);
                var characterService = new CharacterService(context);
                

                ConsoleUtility obj = new ConsoleUtility();
                FeaturesValue obj2 = new FeaturesValue();
                
                bool validator = true;

                do {
                    try
                    {
                        obj.PrintValues("WELCOME TO HELHEIM!", obj.menu);
                        int menu = Convert.ToInt32(Console.ReadLine());


                        switch (menu)
                        {
                            case 0:

                                obj.PrintValues("Enter Your Race: ", obj.races);
                                obj2.SetRace(obj2.EnterValue(obj.races));

                                obj.PrintValues("Enter Your Class: ", obj.classes);
                                obj2.SetClass(obj2.EnterValue(obj.classes));

                                obj.PrintValues("Enter Your Weapon: ", obj.weapons);
                                obj2.SetWeapons(obj2.EnterValue(obj.weapons));

                                obj.PrintValues("Enter Weapon Cosmetic: ", obj.weaponCosmetics);
                                obj2.SetWeaponCosmetic(obj2.EnterValue(obj.weaponCosmetics));

                                obj.PrintValues("Enter Your Skill: ", obj.skills);
                                obj2.SetSkills(obj2.EnterValue(obj.skills));

                                obj.PrintValues("Enter Your Utility: ", obj.utilities);
                                obj2.SetUtilities(obj2.EnterValue(obj.utilities));

                                obj.PrintValues("Enter Armor Type: ", obj.armorTypes);
                                obj2.SetArmorType(obj2.EnterValue(obj.armorTypes));

                                obj.PrintValues("Will Your Armor Show Battle Damage? ", obj.armorBattleDamage);
                                string choice = obj2.EnterValue();
                                bool armorDamage = bool.Parse(choice);
                                obj2.SetArmorDamage(armorDamage);

                                obj.PrintValues("Choose Your Physique: ", obj.physique);
                                obj2.SetPhysique(obj2.EnterValue(obj.physique));

                                obj.PrintValues("Enter Your Height: ", obj.height);
                                obj2.SetHeight(obj2.EnterValue(obj.height));

                                obj.PrintValues("Enter Your Skin Complexity: ", obj.skinComplexities);
                                obj2.SetSkinComplexity(obj2.EnterValue(obj.skinComplexities));

                                obj.PrintValues("Enter Your Hairstyle: ", obj.hairStyles);
                                obj2.SetHairStyle(obj2.EnterValue(obj.hairStyles));

                                obj.PrintValues("Enter Your Hair Color: ", obj.hairColors);
                                obj2.SetHairColor(obj2.EnterValue(obj.hairColors));

                                obj.PrintValues("Enter Your Eye Color: ", obj.eyeColors);
                                obj2.SetEyeColor(obj2.EnterValue(obj.eyeColors));

                                obj.PrintValues("Choose Your Headwear: ", obj.headwear);
                                obj2.SetHeadwear(obj2.EnterValue(obj.headwear));

                                obj.PrintValues("Choose Your Back Accessory: ", obj.backAccessories);
                                obj2.SetBackAccessory(obj2.EnterValue(obj.backAccessories));

                                obj.PrintValues("Choose Your Tattoo: ", obj.tattoos);
                                obj2.SetTattoo(obj2.EnterValue(obj.tattoos));

                                obj.PrintValues("Choose Your Mount: ", obj.mounts);
                                obj2.SetMount(obj2.EnterValue(obj.mounts));

                                obj.PrintValues("Choose Your Pet: ", obj.pets);
                                obj2.SetPet(obj2.EnterValue(obj.pets));

                                obj.PrintValues("Choose Your Lobby Animation: ", obj.lobbyAnimations);
                                obj2.SetLobbyAnimation(obj2.EnterValue(obj.lobbyAnimations));

                                obj.PrintValues("Choose Your Death Animation: ", obj.deathAnimations);
                                obj2.SetDeathAnimation(obj2.EnterValue(obj.deathAnimations));

                                obj.PrintValues("Character Stats: ", obj.stats);
                                int[] resultValues = obj2.EnterValues();

                                obj2.SetWeaponDamage(resultValues[0]);
                                obj2.SetWeaponRange(resultValues[1]);
                                obj2.SetWeaponCriticalDamage(resultValues[2]);
                                obj2.SetWeaponCriticalChance(resultValues[3]);
                                obj2.SetWeaponAmmo(resultValues[4]);
                                obj2.SetWeaponReloadSpeed(resultValues[5]);
                                obj2.SetAccuracy(resultValues[6]);
                                obj2.SetLuck(resultValues[7]);
                                obj2.SetInventoryCapacity(resultValues[8]);


                                FeaturesValue character = new FeaturesValue(
                                    obj2.GetRace(), obj2.GetClass(), obj2.GetWeapons(), obj2.GetWeaponCosmetic(), obj2.GetSkills(),
                                    obj2.GetUtilities(), obj2.GetMount(), obj2.GetPet(), obj2.GetArmorType(), obj2.GetArmorDamage(), obj2.GetPhysique(),
                                    obj2.GetHeight(), obj2.GetSkinComplexity(), obj2.GetHairStyle(), obj2.GetHairColor(), obj2.GetEyeColor(),
                                    obj2.GetHeadwear(), obj2.GetBackAccessory(), obj2.GetTattoo(), obj2.GetLobbyAnimation(), obj2.GetDeathAnimation(),
                                    obj2.GetWeaponDamage(), obj2.GetWeaponRange(), obj2.GetWeaponCriticalDamage(), obj2.GetWeaponCriticalChance(),
                                    obj2.GetWeaponAmmo(), obj2.GetWeaponReloadSpeed(), obj2.GetAccuracy(), obj2.GetLuck(), obj2.GetInventoryCapacity()
                                );

                                
                                var idplusplus = characterService.GetAllCharacters();


                                int maxId = idplusplus
                                    .Where(c => c.ID != null && c.ID.Any(char.IsDigit)) 
                                    .Select(c =>
                                    {
                                        var numericPart = new string(c.ID.Where(char.IsDigit).ToArray());
                                        return int.TryParse(numericPart, out var num) ? num : 0;
                                    })
                                    .DefaultIfEmpty(0) 
                                    .Max(); 
                                
                                int newnumber = maxId + 1;
                                
                                

                                var newCharacter = new SQLentity
                                {
                                    ID = newnumber.ToString(),
                                    Race = obj2.GetRace(),
                                    CharacterClass = obj2.GetClass(),
                                    Weapons = obj2.GetWeapons(),
                                    WeaponCosmetic = obj2.GetWeaponCosmetic(),
                                    Skills = obj2.GetSkills(),
                                    Utilities = obj2.GetUtilities(),
                                    Mount = obj2.GetMount(),
                                    Pet = obj2.GetPet(),
                                    ArmorType = obj2.GetArmorType(),
                                    ArmorDamage = obj2.GetArmorDamage(),
                                    Physique = obj2.GetPhysique(),
                                    Height = obj2.GetHeight(),
                                    SkinComplexity = obj2.GetSkinComplexity(),
                                    HairStyle = obj2.GetHairStyle(),
                                    HairColor = obj2.GetHairColor(),
                                    EyeColor = obj2.GetEyeColor(),
                                    Headwear = obj2.GetHeadwear(),
                                    BackAccessory = obj2.GetBackAccessory(),
                                    Tattoo = obj2.GetTattoo(),
                                    LobbyAnimation = obj2.GetLobbyAnimation(),
                                    DeathAnimation = obj2.GetDeathAnimation(),
                                    WeaponDamage = obj2.GetWeaponDamage(),
                                    WeaponRange = obj2.GetWeaponRange(),
                                    WeaponCriticalDamage = obj2.GetWeaponCriticalDamage(),
                                    WeaponCriticalChance = obj2.GetWeaponCriticalChance(),
                                    WeaponAmmo = obj2.GetWeaponAmmo(),
                                    WeaponReloadSpeed = obj2.GetWeaponReloadSpeed(),
                                    Accuracy = obj2.GetAccuracy(),
                                    Luck = obj2.GetLuck(),
                                    InventoryCapacity = obj2.GetInventoryCapacity()
                                };
                                
                                
                                
                                var createdCharacter = characterService.CreateCharacter(newCharacter);
                                Console.WriteLine("Created Character ID: " +createdCharacter.ID);
                                Console.ReadKey();
                                break;


                            case 1:
                                Console.Clear();
                                Console.WriteLine("\x1b[3J");
                                var allCharacters = characterService.GetAllCharacters();
                                int padding = 25;   
                               foreach (var lcharacter in allCharacters)
                                {
                                    Console.WriteLine(new string('=', padding * 2));
                                    Console.WriteLine("ID:".PadRight(padding) + lcharacter.ID);
                                    Console.WriteLine("Race:".PadRight(padding) + lcharacter.Race);
                                    Console.WriteLine("Class:".PadRight(padding) + lcharacter.CharacterClass);
                                    Console.WriteLine("Weapons:".PadRight(padding) + lcharacter.Weapons);
                                    Console.WriteLine("Weapon Cosmetic:".PadRight(padding) + lcharacter.WeaponCosmetic);
                                    Console.WriteLine("Skills:".PadRight(padding) + lcharacter.Skills);
                                    Console.WriteLine("Utilities:".PadRight(padding) + lcharacter.Utilities);
                                    Console.WriteLine("Mount:".PadRight(padding) + lcharacter.Mount);
                                    Console.WriteLine("Pet:".PadRight(padding) + lcharacter.Pet);
                                    Console.WriteLine("Armor Type:".PadRight(padding) + lcharacter.ArmorType);
                                    Console.WriteLine("Armor Damage:".PadRight(padding) + lcharacter.ArmorDamage);
                                    Console.WriteLine("Physique:".PadRight(padding) + lcharacter.Physique);
                                    Console.WriteLine("Height:".PadRight(padding) + lcharacter.Height);
                                    Console.WriteLine("Skin Complexity:".PadRight(padding) + lcharacter.SkinComplexity);
                                    Console.WriteLine("Hair Style:".PadRight(padding) + lcharacter.HairStyle);
                                    Console.WriteLine("Hair Color:".PadRight(padding) + lcharacter.HairColor);
                                    Console.WriteLine("Eye Color:".PadRight(padding) + lcharacter.EyeColor);
                                    Console.WriteLine("Headwear:".PadRight(padding) + lcharacter.Headwear);
                                    Console.WriteLine("Back Accessory:".PadRight(padding) + lcharacter.BackAccessory);
                                    Console.WriteLine("Tattoo:".PadRight(padding) + lcharacter.Tattoo);
                                    Console.WriteLine("Lobby Animation:".PadRight(padding) + lcharacter.LobbyAnimation);
                                    Console.WriteLine("Death Animation:".PadRight(padding) + lcharacter.DeathAnimation);
                                    Console.WriteLine("Weapon Damage:".PadRight(padding) + lcharacter.WeaponDamage);
                                    Console.WriteLine("Weapon Range:".PadRight(padding) + lcharacter.WeaponRange);
                                    Console.WriteLine("Weapon Critical Damage:".PadRight(padding) + lcharacter.WeaponCriticalDamage);
                                    Console.WriteLine("Weapon Critical Chance:".PadRight(padding) + lcharacter.WeaponCriticalChance);
                                    Console.WriteLine("Weapon Ammo:".PadRight(padding) + lcharacter.WeaponAmmo);
                                    Console.WriteLine("Weapon Reload Speed:".PadRight(padding) + lcharacter.WeaponReloadSpeed);
                                    Console.WriteLine("Accuracy:".PadRight(padding) + lcharacter.Accuracy);
                                    Console.WriteLine("Luck:".PadRight(padding) + lcharacter.Luck);
                                    Console.WriteLine("Inventory Capacity:".PadRight(padding) + lcharacter.InventoryCapacity);
                                    Console.WriteLine(new string('=', padding * 2));
                                }

                                
                                try{
                                if (allCharacters.Any() == true)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Do you want to delete a character? (y/n)");
                                    
                                        char value = Console.ReadLine()[0];
                                        char lowerCaseChar = char.ToLower(value);

                                        if (lowerCaseChar == 'y')
                                        {
                                            bool hasCharacters = characterService.HasAnyCharacter();
                                            if (!hasCharacters)
                                            {
                                                Console.WriteLine("No existing characters found in the database.");
                                            }
                                            else
                                            {
                                                Console.Write("Enter the character ID to delete: ");
                                                var deleteId = Console.ReadLine();

                                                SQLentity? delcharacter = characterService.GetCharacterById(deleteId);

                                                Console.WriteLine("Are you sure you want to delete character ID: " +
                                                                  deleteId + " ?(y/n)");

                                                char verify = Console.ReadLine()[0];
                                                char lowerverify = char.ToLower(value);
                                                if (lowerCaseChar == 'y')
                                                {
                                                    var isDeleted = characterService.DeleteCharacter(deleteId);
                                                    if (isDeleted)
                                                    {
                                                        Console.WriteLine("Character deleted successfully.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Character not found or could not be deleted.");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Character not deleted.");
                                                }
                                            }

                                            Console.ReadKey();


                                        }
                                        else if (lowerCaseChar == 'n')
                                        {
                                            Console.WriteLine("Exiting");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Input");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No load data");
                                        Console.ReadKey();
                                    }
                                }
                                catch (IndexOutOfRangeException) {
                                    Console.WriteLine("Error: Invalid input. Please enter a number.");
                                    Console.ReadKey();
                                }


                                break;



                            case 2:
                                TypeWriterEffect("In the world of Azeroth, Orcs, Dwarves, Elves, Undead, and Humans once lived in peace, united by a common bond.");
                                TypeWriterEffect("However, the harmony was shattered when a colossal World Tree suddenly sprouted, altering the land and disturbing the balance.");
                                TypeWriterEffect("The ancient forces of Corruption, Deception, and Chaos infiltrated the minds of these tribes, implanting visions that another tribe had committed");
                                TypeWriterEffect("heinous acts against them. These illusions ignited a catastrophic war that raged for 500 years, claiming the lives of countless warriors.");
                                TypeWriterEffect("With so many souls lost, Valhalla, the resting place of the brave, became overcrowded and could no longer accommodate the fallen.");
                                Thread.Sleep(1000);

                                Console.WriteLine();
                                TypeWriterEffect("In a desperate bid to restore order, the Ruler of Valhalla made a pact with Lucifer, the ruler of Hell, to establish a way to filter which souls");
                                TypeWriterEffect("were worthy of rest. They devised a brutal battle royal: every hour, 100 souls would be thrust into Dante’s Inferno, forced to fight one another in a");
                                TypeWriterEffect("deadly contest for a chance at entering Valhalla. Every three minutes, the arena would grow more treacherous, with the souls being pushed deeper into Hell,");
                                TypeWriterEffect("their strength and will tested by relentless challenges. Only the last remaining victor would secure their place in Valhalla, while the rest would be");
                                TypeWriterEffect("lost to the endless torment of the abyss.");
                                Thread.Sleep(1000);

                                Console.WriteLine();
                                TypeWriterEffect("The once-glorious realm of Valhalla now stood as a place of final judgment, where warriors fought not just for honor, but for the right to rest in peace.");
                                TypeWriterEffect("The battle royal became an eternal cycle, where warriors from different tribes and histories faced each other in a blood-soaked struggle.");
                                TypeWriterEffect("The victorious souls would ascend to Valhalla, their names remembered in legend, while the fallen would join the depths of Hell.");
                                TypeWriterEffect("Azeroth, now marked by constant warfare and competition, became a world where only the strongest could ever hope to find peace.");
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.WriteLine("Ron Bugarin (Pancit Canton) ");
                                Console.WriteLine("Rogin Tiu (Documentationist) ");
                                Console.WriteLine("Edison Odal (Programmerist) ");
                                Console.ReadKey();
                                break;

                            case 4:
                                Console.WriteLine("Ending Program!");
                                Console.ReadKey();
                                validator = false;
                                Environment.Exit(0);
                                break;

                            default:

                                Console.WriteLine("Invalid Input!");
                                Console.ReadKey();
                                break;
                        }
                    }
                    catch (FormatException) { }
                }while(validator = true);
        }
        }


    }