using System.Numerics;

namespace UnitTestsBuilderPattern_Demo.src;

public class Enemy
{
    public Enemy(
        string name,
        string npcType,
        int maxHealth,
        int level,
        int armor,
        int magicResistance,
        Vector3 position,
        int strength,
        List<string> lootTable)
    {
        Name = name;
        NpcType = npcType;
        Health = maxHealth;
        MaxHealth = maxHealth;
        Level = level;
        Armor = armor;
        MagicResistance = magicResistance;
        Position = position;
        Strength = strength;
        LootTable = lootTable;
    }

    private string Name { get; }

    private string NpcType { get; }

    public int Health { get; private set; }

    private int MaxHealth { get; }

    private int Level { get; }

    private int Armor { get; }

    private int MagicResistance { get; }

    private Vector3 Position { get; }

    private int Strength { get; }

    private List<string> LootTable { get; }

    public int ReceiveDamage(decimal damage)
    {
        Health -= (int)damage;
        if(Health < 0) 
            Health = 0;

        return Health;
    }
}
