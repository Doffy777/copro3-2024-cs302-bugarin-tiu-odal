        namespace BattleRoyalGame
        {
            public interface Features
            {

                    void SetRace(string race);
                    string GetRace();

                    void SetClass(string characterClass);
                    string GetClass();

                    void SetWeapons(string weapons);
                    string GetWeapons();

                    void SetWeaponCosmetic(string weaponCosmetic);
                    string GetWeaponCosmetic();

                    void SetSkills(string skills);
                    string GetSkills();

                    void SetUtilities(string utilities);
                    string GetUtilities();

                    void SetMount(string mount);
                    string GetMount();

                    void SetPet(string pet);
                    string GetPet();

                    void SetArmorType(string armorType);
                    string GetArmorType();

                    void SetArmorDamage(bool armorDamage);
                    bool GetArmorDamage();

                    void SetPhysique(string physique);
                    string GetPhysique();

                    void SetHeight(string height);
                    string GetHeight();

                    void SetSkinComplexity(string skinComplexity);
                    string GetSkinComplexity();

                    void SetHairStyle(string hairStyle);
                    string GetHairStyle();

                    void SetHairColor(string hairColor);
                    string GetHairColor();

                    void SetEyeColor(string eyeColor);
                    string GetEyeColor();

                    void SetHeadwear(string headwear);
                    string GetHeadwear();

                    void SetBackAccessory(string backAccessory);
                    string GetBackAccessory();

                    void SetTattoo(string tattoo);
                    string GetTattoo();

                    void SetLobbyAnimation(string lobbyAnimation);
                    string GetLobbyAnimation();

                    void SetDeathAnimation(string deathAnimation);
                    string GetDeathAnimation();

                    void SetWeaponDamage(int weaponDamage);
                    int GetWeaponDamage();

                    void SetWeaponRange(int weaponRange);
                    int GetWeaponRange();

                    void SetWeaponCriticalDamage(int weaponCriticalDamage);
                    int GetWeaponCriticalDamage();

                    void SetWeaponCriticalChance(int weaponCriticalChance);
                    int GetWeaponCriticalChance();

                    void SetWeaponAmmo(int weaponAmmo);
                    int GetWeaponAmmo();

                    void SetWeaponReloadSpeed(int weaponReloadSpeed);
                    int GetWeaponReloadSpeed();

                    void SetAccuracy(int accuracy);
                    int GetAccuracy();

                    void SetLuck(int luck);
                    int GetLuck();

                    void SetInventoryCapacity(int inventoryCapacity);
                    int GetInventoryCapacity();


                string EnterValue(string[] array);
            }
        }