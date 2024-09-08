namespace UnitTestsBuilderPattern_Demo.src;

public record Sword : BaseWeapon
{
    public Sword(
        string name,
        string equipmentSlot,
        int baseDamage,
        string rarity)
    {
        Name = name;
        EquipmentSlot = equipmentSlot;
        BaseDamage = baseDamage;
        Rarity = rarity;
        DamageType = DamageType.Physical;
    }
}
