using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthTest
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(100, 0, 0)]
    [TestCase(10, 100, 100)]
    [TestCase(50, 10, 60)]
    public void HealthPositiveTest(int damage, int heal, int expectedResult)
    {
        //Arrange
        var health = new EntityHealth();
        health.CurrentHealth = 100;

        //Act
        health.Damage(damage);
        health.Heal(heal);

        //Assert
        Assert.AreEqual(expectedResult, health.CurrentHealth);
    }

  
}
