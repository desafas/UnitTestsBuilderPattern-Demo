using UnitTestsBuilderPattern_Demo.src;

namespace UnitTestsBuilderPattern_Demo.Tests;

internal class WeaponBuilder
{
    private string Name;
    private string EquipmentSlot;
    private int BaseDamage;
    private string Rarity;

    public WeaponBuilder WithName(string name)
    {
        Name = name;
        return this;
    }

    public WeaponBuilder WithEquipmentSlot(string equipmentSlot)
    {
        EquipmentSlot = equipmentSlot;
        return this;
    }

    public WeaponBuilder WithBaseDamage(int baseDamage)
    {
        BaseDamage = baseDamage;
        return this;
    }

    public WeaponBuilder WithRarity(string rarity)
    {
        Rarity = rarity;
        return this;
    }

    public Sword BuildMelee()
    {
        return new Sword(
            Name,
            EquipmentSlot,
            BaseDamage,
            Rarity);
    }

    public Sword BuildSpell()
    {
        return new Sword(
            Name,
            EquipmentSlot,
            BaseDamage,
            Rarity);
    }
}
