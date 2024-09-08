using System.Numerics;

namespace UnitTestsBuilderPattern_Demo.src
{
    internal class PlayerBuilder
    {
        private string Name;
        private string ClassType;
        private string Faction;
        private int Health;
        private int MaxHealth;
        private int Mana;
        private int Level;
        private int Experience;
        private int Armor;
        private int MagicResistance;
        private int Gold;
        private List<string> Inventory = new List<string>();
        private Vector3 Position;
        private int Strength;
        private int SpellPower;
        private BaseWeapon MeleeWeapon;
        private BaseWeapon Spell;

        public PlayerBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public PlayerBuilder WithClassType(string classType)
        {
            ClassType = classType;
            return this;
        }

        public PlayerBuilder WithFaction(string faction)
        {
            Faction = faction;
            return this;
        }

        public PlayerBuilder WithHealth(int health)
        {
            Health = health;
            return this;
        }

        public PlayerBuilder WithMaxHealth(int maxHealth)
        {
            MaxHealth = maxHealth;
            return this;
        }

        public PlayerBuilder WithMana(int mana)
        {
            Mana = mana;
            return this;
        }

        public PlayerBuilder WithLevel(int level)
        {
            Level = level;
            return this;
        }

        public PlayerBuilder WithExperience(int experience)
        {
            Experience = experience;
            return this;
        }

        public PlayerBuilder WithArmor(int armor)
        {
            Armor = armor;
            return this;
        }

        public PlayerBuilder WithMagicResistance(int magicResistance)
        {
            MagicResistance = magicResistance;
            return this;
        }

        public PlayerBuilder WithGold(int gold)
        {
            Gold = gold;
            return this;
        }

        public PlayerBuilder WithInventory(List<string> inventory)
        {
            Inventory = inventory;
            return this;
        }

        public PlayerBuilder WithPosition(Vector3 position)
        {
            Position = position;
            return this;
        }

        public PlayerBuilder WithStrength(int strength)
        {
            Strength = strength;
            return this;
        }

        public PlayerBuilder WithSpellPower(int spellPower)
        {
            SpellPower = spellPower;
            return this;
        }

        public PlayerBuilder WithMeleeWeapon(BaseWeapon meleeWeapon)
        {
            MeleeWeapon = meleeWeapon;
            return this;
        }

        public PlayerBuilder WithSpell(BaseWeapon spell)
        {
            Spell = spell;
            return this;
        }

        public Player Build()
        {
            return new Player(
                Name,
                ClassType,
                Faction,
                Health,
                MaxHealth,
                Mana,
                Level,
                Experience,
                Armor,
                MagicResistance,
                Gold,
                Inventory,
                Position,
                Strength,
                SpellPower,
                MeleeWeapon,
                Spell
            );
        }
    }
}
