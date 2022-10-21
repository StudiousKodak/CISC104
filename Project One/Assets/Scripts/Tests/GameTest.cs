using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GameTest
{
    // Test Default User
    [Test]
    public void TestUserDeault()
    {
        User defaultUser = new User();

        // Assert
        // Test getHP
        Assert.AreEqual(100, defaultUser.getHP());
        // Test getAttack
        Assert.AreEqual(20, defaultUser.getAttack());
        // Test getSpeed
        Assert.AreEqual(5.0f, defaultUser.getSpeed());
        // Test getHP Pot
        Assert.AreEqual(2, defaultUser.getPot());
    }

    // Test Default Enemy
    [Test]
    public void TestEnemyDefault()
    {
        Enemy defaultEnemy = new Enemy();

        // Assert
        // Test getHP
        Assert.AreEqual(20, defaultEnemy.getHP());
        // Test getAttack
        Assert.AreEqual(10, defaultEnemy.getAttack());
        // Test getSpeed
        Assert.AreEqual(4.0f, defaultEnemy.getSpeed());
        // Test getName
        Assert.AreEqual("Goblin", defaultEnemy.getName());
        // Test getItem
        Assert.AreEqual("Goblins Pouch", defaultEnemy.getItem());
    }

    // Test Created Enemy
    [Test]
    public void TestEnemyCreated()
    {
        Enemy vampEnemy = new Enemy(40, 30, 5.5f, "Vamp", "Vamp Cloak");

        // Assert
        // Test getHP
        Assert.AreEqual(40, vampEnemy.getHP());
        // Test getAttack
        Assert.AreEqual(30, vampEnemy.getAttack());
        // Test getSpeed
        Assert.AreEqual(5.5f, vampEnemy.getSpeed());
        // Test getName
        Assert.AreEqual("Vamp", vampEnemy.getName());
        // Test getItem
        Assert.AreEqual("Vamp Cloak", vampEnemy.getItem());
    }

    // Test setHP for user and enemy
    [Test]
    public void testSetHP()
    {
        Enemy testEnemy = new Enemy(10, 10, 5.0f, "Test", "Nothing");

        User testUser = new User();
        // Test setHP user
        Assert.AreEqual(100, testUser.getHP());
        testUser.setHP(testUser.getHP() + 50);
        Assert.AreEqual(150, testUser.getHP());

        // Test setHP enemy
        Assert.AreEqual(10, testEnemy.getHP());
        testEnemy.setHP(testEnemy.getHP() + 10);
        Assert.AreEqual(20, testEnemy.getHP());
    }
}
