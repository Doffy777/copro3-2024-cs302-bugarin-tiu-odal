using Microsoft.EntityFrameworkCore;
namespace BattleRoyalGame;

public class SQLentity
{
    public string ID { get; set; }
    public string Race { get; set; }
    public string CharacterClass { get; set; }
    public string Weapons { get; set; }
    public string WeaponCosmetic { get; set; }
    public string Skills { get; set; }
    public string Utilities { get; set; }
    public string Mount { get; set; }
    public string Pet { get; set; }
    public string ArmorType { get; set; }
    public bool ArmorDamage { get; set; }
    public string Physique { get; set; }
    public string Height { get; set; }
    public string SkinComplexity { get; set; }
    public string HairStyle { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Headwear { get; set; }
    public string BackAccessory { get; set; }
    public string Tattoo { get; set; }
    public string LobbyAnimation { get; set; }
    public string DeathAnimation { get; set; }
    public int WeaponDamage { get; set; }
    public int WeaponRange { get; set; }
    public int WeaponCriticalDamage { get; set; }
    public int WeaponCriticalChance { get; set; }
    public int WeaponAmmo { get; set; }
    public int WeaponReloadSpeed { get; set; }
    public int Accuracy { get; set; }
    public int Luck { get; set; }
    public int InventoryCapacity { get; set; }
}

public class BattleroyalDb : DbContext
{
    public DbSet<SQLentity?> Character { get; set; }
    public BattleroyalDb(DbContextOptions<BattleroyalDb> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySql("server=localhost;database=battleroyaldb;user=root;password=122333",
            new MySqlServerVersion(new Version(8, 0, 40)));
    }
}


    