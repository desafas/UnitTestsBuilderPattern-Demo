namespace UnitTestsBuilderPattern_Demo.src;

public record Fireball : BaseWeapon
{
    public Fireball(
        string name,
        string equipmentSlot,
        int baseDamage,
        string rarity)
    {
        Name = name;
        EquipmentSlot = equipmentSlot;
        BaseDamage = baseDamage;
        Rarity = rarity;
        DamageType = DamageType.Magical;
    }
}
