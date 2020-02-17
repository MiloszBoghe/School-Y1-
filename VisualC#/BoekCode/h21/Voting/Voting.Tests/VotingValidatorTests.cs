using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Voting.Tests
{
    [TestClass]
    public class VotingValidatorTests
    {
        //[TestMethod]
        //public void CheckWhenOlderThan17_ReturnTrue()
        //{
        //    // Arrange
        //    VotingValidator validator = new VotingValidator();
        //    int age = 41;
        //    bool expectedOutcome = true;

        //    // Act
        //    bool actualOutcome = validator.Check(age);

        //    // Assert
        //    Assert.AreEqual(expectedOutcome, actualOutcome);
        //}

        [TestMethod]
        public void CheckWhenOlderThan17_ReturnTrue()
        {
            // Arrange
            VotingValidator validator = new VotingValidator();
            int age = 41;
            

            // Act
            bool youMayVote = validator.Check(age);

            // Assert
            Assert.IsTrue(youMayVote);
        }

        [TestMethod]
        public void CheckWhenYoungerThan17_ReturnsFalse()
        {
            // Arrange
            VotingValidator validator = new VotingValidator();
            int age = 6;
            bool expectedOutcome = false;

            // Act
            bool actualOutcome = validator.Check(age);

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome);
        }

        [TestMethod]
        public void CheckWhen17_ReturnsFalse()
        {
            // Arrange
            VotingValidator validator = new VotingValidator();
            int age = 17;
            bool expectedOutcome = false;

            // Act
            bool actualOutcome = validator.Check(age);

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckWhenNegativeAge_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            VotingValidator validator = new VotingValidator();
            int age = -20;

            // Act
            bool actualOutcome = validator.Check(age);

            // Assert - Exception should be thrown
        }
    }
}
