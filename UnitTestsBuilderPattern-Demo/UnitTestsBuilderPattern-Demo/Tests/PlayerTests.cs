using NUnit.Framework;
using UnitTestsBuilderPattern_Demo.src;

namespace UnitTestsBuilderPattern_Demo.Tests;

public class PlayerTests
{
    [Test]
    public void When_player_attacks_with_melee_weapon_enemy_health_is_lower_than_before__Without_Builder__()
    {
        // Arrange
        var player = new Player(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            strength: 10,
            spellPower: 20,
            new Sword(
                "Anduril",
                default,
                10,
                default),
            new Fireball(
                "Balrogs’ Fire",
                default,
                20,
                default)
            );

        var initialEnemyHealth = 100;
        var enemy = new Enemy(
            default,
            default,
            initialEnemyHealth,
            default,
            default,
            30,
            default,
            default,
            default);

        //Act
        var newEnemyHealth = player.Attack(DamageType.Physical, enemy);

        //Assert
        Assert.That(newEnemyHealth, Is.LessThan(initialEnemyHealth));
    }

    [Test]
    public void When_player_attacks_with_melee_weapon_enemy_health_is_lower_than_before__With_Builder__()
    {
        // Arrange
        var player = new PlayerBuilder()
            .WithStrength(10)
            .WithSpellPower(20)
            .WithMeleeWeapon(new WeaponBuilder()
                .WithName("Anduril")
                .WithBaseDamage(10)
                .BuildMelee())
            .WithSpell(new WeaponBuilder()
                .WithName("Balrogs’ Fire")
                .WithBaseDamage(20)
                .BuildSpell())
            .Build();

        var initialEnemyHealth = 100;
        var enemy = new EnemyBuilder()
            .WithMaxHealth(initialEnemyHealth)
            .WithArmor(30)
            .Build();

        //Act
        var newEnemyHealth = player.Attack(DamageType.Physical, enemy);

        //Assert
        Assert.That(newEnemyHealth, Is.LessThan(initialEnemyHealth));
    }
}
