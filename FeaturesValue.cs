namespace BattleRoyalGame
{
    public struct FeaturesValue : Features
    {

        private string race;
        private string characterClass;
        private string weapons;
        private string weaponCosmetic;
        private string skills;
        private string utilities;
        private string mount;
        private string pet;
        private string armorType;
        private string physique;
        private string height;
        private string skinComplexity;
        private string hairStyle;
        private string hairColor;
        private string eyeColor;
        private string headwear;
        private string backAccessory;
        private string tattoo;
        private string lobbyAnimation;
        private string deathAnimation;

        private bool armorDamage;

        private int weaponDamage;
        private int weaponRange;
        private int weaponCriticalDamage;
        private int weaponCriticalChance;
        private int weaponAmmo;
        private int weaponReloadSpeed;
        private int accuracy;
        private int luck;
        private int inventoryCapacity;

        public void SetRace(string race) { this.race = race; }
        public string GetRace() { return this.race; }

        public void SetClass(string characterClass) { this.characterClass = characterClass; }
        public string GetClass() { return this.characterClass; }

        public void SetWeapons(string weapons) { this.weapons = weapons; }
        public string GetWeapons() { return this.weapons; }

        public void SetWeaponCosmetic(string weaponCosmetic) { this.weaponCosmetic = weaponCosmetic; }
        public string GetWeaponCosmetic() { return this.weaponCosmetic; }

        public void SetSkills(string skills) { this.skills = skills; }
        public string GetSkills() { return this.skills; }

        public void SetUtilities(string utilities) { this.utilities = utilities; }
        public string GetUtilities() { return this.utilities; }

        public void SetArmorType(string armorType) { this.armorType = armorType; }
        public string GetArmorType() { return this.armorType; }

        public void SetArmorDamage(bool armorDamage) { this.armorDamage = armorDamage; }
        public bool GetArmorDamage() { return this.armorDamage; }

        public void SetPhysique(string physique) { this.physique = physique; }
        public string GetPhysique() { return this.physique; }

        public void SetHeight(string height) { this.height = height; }
        public string GetHeight() { return this.height; }

        public void SetSkinComplexity(string skinComplexity) { this.skinComplexity = skinComplexity; }
        public string GetSkinComplexity() { return this.skinComplexity; }

        public void SetHairStyle(string hairStyle) { this.hairStyle = hairStyle; }
        public string GetHairStyle() { return this.hairStyle; }

        public void SetHairColor(string hairColor) { this.hairColor = hairColor; }
        public string GetHairColor() { return this.hairColor; }

        public void SetEyeColor(string eyeColor) { this.eyeColor = eyeColor; }
        public string GetEyeColor() { return this.eyeColor; }

        public void SetHeadwear(string headwear) { this.headwear = headwear; }
        public string GetHeadwear() { return this.headwear; }

        public void SetBackAccessory(string backAccessory) { this.backAccessory = backAccessory; }
        public string GetBackAccessory() { return this.backAccessory; }

        public void SetTattoo(string tattoo) { this.tattoo = tattoo; }
        public string GetTattoo() { return this.tattoo; }

        public void SetMount(string mount) { this.mount = mount; }
        public string GetMount() { return this.mount; }

        public void SetPet(string pet) { this.pet = pet; }
        public string GetPet() { return this.pet; }

        public void SetLobbyAnimation(string lobbyAnimation) { this.lobbyAnimation = lobbyAnimation; }
        public string GetLobbyAnimation() { return this.lobbyAnimation; }

        public void SetDeathAnimation(string deathAnimation) { this.deathAnimation = deathAnimation; }
        public string GetDeathAnimation() { return this.deathAnimation; }

        public void SetWeaponDamage(int weaponDamage) { this.weaponDamage = weaponDamage; }
        public int GetWeaponDamage() { return this.weaponDamage; }

        public void SetWeaponRange(int weaponRange) { this.weaponRange = weaponRange; }
        public int GetWeaponRange() { return this.weaponRange; }

        public void SetWeaponCriticalDamage(int weaponCriticalDamage) { this.weaponCriticalDamage = weaponCriticalDamage; }
        public int GetWeaponCriticalDamage() { return this.weaponCriticalDamage; }

        public void SetWeaponCriticalChance(int weaponCriticalChance) { this.weaponCriticalChance = weaponCriticalChance; }
        public int GetWeaponCriticalChance() { return this.weaponCriticalChance; }

        public void SetWeaponAmmo(int weaponAmmo) { this.weaponAmmo = weaponAmmo; }
        public int GetWeaponAmmo() { return this.weaponAmmo; }

        public void SetWeaponReloadSpeed(int weaponReloadSpeed) { this.weaponReloadSpeed = weaponReloadSpeed; }
        public int GetWeaponReloadSpeed() { return this.weaponReloadSpeed; }

        public void SetAccuracy(int accuracy) { this.accuracy = accuracy; }
        public int GetAccuracy() { return this.accuracy; }

        public void SetLuck(int luck) { this.luck = luck; }
        public int GetLuck() { return this.luck; }

        public void SetInventoryCapacity(int inventoryCapacity) { this.inventoryCapacity = inventoryCapacity; }
        public int GetInventoryCapacity() { return this.inventoryCapacity; }


        public FeaturesValue(string race, string characterClass, string weapons, string weaponCosmetic, string skills, string utilities,
            string mount, string pet, string armorType, bool armorDamage, string physique, string height,
            string skinComplexity, string hairStyle, string hairColor, string eyeColor, string headwear,
            string backAccessory, string tattoo, string lobbyAnimation, string deathAnimation, int weaponDamage, int weaponRange, int weaponCriticalDamage,
            int weaponCriticalChance, int weaponAmmo, int weaponReloadSpeed, int accuracy, int luck, int inventoryCapacity)
        {
            Console.Clear();
            Console.WriteLine("Race: " + race);
            Console.WriteLine("Class: " + characterClass);
            Console.WriteLine("Weapon: " + weapons);
            Console.WriteLine("Weapon Cosmetic: " + weaponCosmetic);
            Console.WriteLine("Skill: " + skills);
            Console.WriteLine("Utility: " + utilities);
            Console.WriteLine("Mount: " + mount);
            Console.WriteLine("Pet: " + pet);
            Console.WriteLine("Armor Type: " + armorType);
            Console.WriteLine("Armor Damage: " + armorDamage);
            Console.WriteLine("Physique: " + physique);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Skin Complexity: " + skinComplexity);
            Console.WriteLine("Hair Style: " + hairStyle);
            Console.WriteLine("Hair Color: " + hairColor);
            Console.WriteLine("Eye Color: " + eyeColor);
            Console.WriteLine("Headwear: " + headwear);
            Console.WriteLine("Back Accessory: " + backAccessory);
            Console.WriteLine("Tattoo: " + tattoo);
            Console.WriteLine("Lobby Animation: " + lobbyAnimation);
            Console.WriteLine("Death Animation: " + deathAnimation);
            Console.WriteLine(" ");
            Console.WriteLine("Here are the status of your Character ");
            Console.WriteLine("Weapon Damage: " + weaponDamage);
            Console.WriteLine("Weapon Range: " + weaponRange);
            Console.WriteLine("Weapon Critical Damage: " + weaponCriticalDamage);
            Console.WriteLine("Weapon Critical Chance: " + weaponCriticalChance);
            Console.WriteLine("Weapon Ammo: " + weaponAmmo);
            Console.WriteLine("Weapon Reload Speed: " + weaponReloadSpeed);
            Console.WriteLine("Accuracy: " + accuracy);
            Console.WriteLine("Luck: " + luck);
            Console.WriteLine("Inventory Capacity: " + inventoryCapacity);

           

        }


        public class UserException : Exception
        {
            public UserException(string message) : base(message) { }
        }

        public string EnterValue(string[] array)
        {
            string inputValue = null;
            int input;

            do
            {
                try
                {
                    Console.WriteLine("Choose from (0 to " + (array.Length - 1) + "):");
                    input = Convert.ToInt32(Console.ReadLine());

                    inputValue = array[input];
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error: Input is out of range. Please try again.");
                }
            } while (inputValue == null);
            string[] splitValue = inputValue.Split(' ');
            return inputValue = splitValue[0];
        }

        public string EnterValue()
        {
            string value = null;
            int input;

            do
            {
                try
                {
                    Console.WriteLine("[0] True or [1] False");
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input == 0)
                    {
                        value = "true";
                    }
                    else if (input == 1)
                    {
                        value = "false";
                    }
                    else
                    {
                        throw new UserException("Invalid input. Please enter a valid number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number.");
                }
                catch (UserException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (value == null);

            return value;
        }



        public int[] EnterValues()
        {
            int[] values = new int[9];

            int i = 0;
            int allotedValue = 20;
            ConsoleUtility obj = new ConsoleUtility();

            for (int a = 0; a < 9; a++)
            {
                try
                {

                    if (allotedValue <= 0)
                    {
                        break;
                    }
                   
                    Console.WriteLine(obj.stats[a] + " (Max of each stat is 5) " + allotedValue + " points left");
                    values[a] += Convert.ToInt32(Console.ReadLine());

                    if (values[a] > 5 || values[a] < 0 || values[a] >allotedValue)
                    {
                        Console.WriteLine("Error: Invalid input. Please try again");
                        values[a] = 0;
                        a--;
                    }
                    else
                    {
                        allotedValue -= values[a];
                    }

                    if (allotedValue > 0 && a == 8)
                    {
                        Console.WriteLine("You have more points to allocate do it again");
                        Thread.Sleep(3000);
                        a = -1;
                        allotedValue = 20;
                        Array.Clear(values, 0, values.Length);

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number.");
                    a--;
                }
            }
            return values;
        }

        
      
          

    }
}
