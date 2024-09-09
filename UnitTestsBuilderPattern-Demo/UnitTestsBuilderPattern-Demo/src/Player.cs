using System.Numerics;

namespace UnitTestsBuilderPattern_Demo.src;

public class Player
{
    public Player(
        string name,
        string classType,
        string faction,
        int health,
        int maxHealth,
        int mana,
        int level,
        int experience,
        int armor,
        int magicResistance,
        int gold,
        List<string> inventory,
        Vector3 position,
        int strength,
        int spellPower,
        BaseWeapon meleeWeapon,
        BaseWeapon spell)
    {
        Name = name;
        ClassType = classType;
        Faction = faction;
        Health = health;
        MaxHealth = maxHealth;
        Mana = mana;
        Level = level;
        Experience = experience;
        Armor = armor;
        MagicResistance = magicResistance;
        Inventory = inventory;
        Strength = strength;
        SpellPower = spellPower;
        MeleeWeapon = meleeWeapon;
        Spell = spell;
    }

    private string Name { get; }

    private string ClassType { get; }

    private string Faction { get; }

    private int Health { get; }

    private int MaxHealth { get; }

    private int Mana { get; }

    private int Level { get; }

    private int Experience { get; }

    private int Armor { get; }

    private int MagicResistance { get; }

    private int Gold { get; }

    private List<string> Inventory { get; }

    private Vector3 Position { get; }

    private int Strength { get; }

    private int SpellPower { get; }

    private BaseWeapon MeleeWeapon { get; }

    private BaseWeapon Spell { get; }

    public int Attack(DamageType damageType, Enemy enemy)
    {
        var damage = damageType switch
        {
            DamageType.Physical => MeleeWeapon.BaseDamage + Strength * 0.1m,
            DamageType.Magical => Spell.BaseDamage + SpellPower * 0.05m,
            _ => throw new InvalidOperationException("Unknown damage type")
        };

        return enemy.ReceiveDamage(damage);
    }
}
