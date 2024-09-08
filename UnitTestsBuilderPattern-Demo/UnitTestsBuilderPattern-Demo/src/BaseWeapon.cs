namespace UnitTestsBuilderPattern_Demo.src;

public abstract record BaseWeapon
{
    public string Name { get; init; }

    public string EquipmentSlot { get; init; }

    public int BaseDamage { get; init; }

    public DamageType DamageType { get; init; }

    public string Rarity { get; init; }
}
