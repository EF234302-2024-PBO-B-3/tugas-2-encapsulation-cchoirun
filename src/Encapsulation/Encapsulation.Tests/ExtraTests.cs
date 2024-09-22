using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encapsulation.Extras;

namespace Encapsulation.Tests
{
    [TestClass]
    public class ExtraTests
    {
        [TestMethod]
        public void Constructor_WithValidValues_ShouldSetProperties()
        {
            // Arrange & Act
            Extra extra = new Extra("Toyota", "Corolla", 50);

            // Assert
            Assert.AreEqual("Toyota", extra.Brand);
            Assert.AreEqual("Corolla", extra.Model);
            Assert.AreEqual(50, extra.FuelLevel);
        }

        [TestMethod]
        public void Constructor_WithNegativeFuelLevel_ShouldSetFuelLevelToZero()
        {
            // Arrange & Act
            Extra extra = new Extra("Toyota", "Corolla", -10);

            // Assert
            Assert.AreEqual(0, extra.FuelLevel);
        }

        [TestMethod]
        public void Refuel_WithPositiveAmount_ShouldIncreaseFuelLevel()
        {
            // Arrange
            Extra extra = new Extra("Toyota", "Corolla", 10);

            // Act
            extra.Refuel(20);

            // Assert
            Assert.AreEqual(30, extra.FuelLevel);
        }

        [TestMethod]
        public void Drive_WithSufficientFuel_ShouldReduceFuelLevel()
        {
            // Arrange
            Extra extra = new Extra("Toyota", "Corolla", 50);

            // Act
            bool success = extra.Drive(100); // Needs 10 liters

            // Assert
            Assert.IsTrue(success);
            Assert.AreEqual(40, extra.FuelLevel);
        }

        [TestMethod]
        public void Drive_WithInsufficientFuel_ShouldNotChangeFuelLevel()
        {
            // Arrange
            Extra extra = new Extra("Toyota", "Corolla", 5);

            // Act
            bool success = extra.Drive(100); // Needs 10 liters

            // Assert
            Assert.IsFalse(success);
            Assert.AreEqual(5, extra.FuelLevel);
        }
    }
}
