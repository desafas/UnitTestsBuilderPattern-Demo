using System.Numerics;

namespace UnitTestsBuilderPattern_Demo.src
{
    internal class EnemyBuilder
    {
        private string Name;
        private string NpcType;
        private int MaxHealth;
        private int Level;
        private int Armor;
        private int MagicResistance;
        private Vector3 Position;
        private int Strength;
        private List<string> LootTable = new List<string>();

        public EnemyBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public EnemyBuilder WithNpcType(string npcType)
        {
            NpcType = npcType;
            return this;
        }

        public EnemyBuilder WithMaxHealth(int maxHealth)
        {
            MaxHealth = maxHealth;
            return this;
        }

        public EnemyBuilder WithLevel(int level)
        {
            Level = level;
            return this;
        }

        public EnemyBuilder WithArmor(int armor)
        {
            Armor = armor;
            return this;
        }

        public EnemyBuilder WithMagicResistance(int magicResistance)
        {
            MagicResistance = magicResistance;
            return this;
        }

        public EnemyBuilder WithPosition(Vector3 position)
        {
            Position = position;
            return this;
        }

        public EnemyBuilder WithStrength(int strength)
        {
            Strength = strength;
            return this;
        }

        public EnemyBuilder WithLootTable(List<string> lootTable)
        {
            LootTable = lootTable;
            return this;
        }

        public Enemy Build()
        {
            return new Enemy(
                Name,
                NpcType,
                MaxHealth,
                Level,
                Armor,
                MagicResistance,
                Position,
                Strength,
                LootTable
            );
        }
    }
}
