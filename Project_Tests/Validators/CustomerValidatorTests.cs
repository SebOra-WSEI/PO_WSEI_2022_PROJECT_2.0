using BOOKSTORE_PROJECT_PO.Validators;
using NUnit.Framework;

namespace Project_Tests
{
    public class CustomerValidatorTests
    {
        private CustomerValidator validator = new CustomerValidator();


        [Test]
        public void WhenFirstNameHas30CharsShouldReturnOk()
        {
            // Act
            var validationResult = validator.Validate("aaaaaaaaaabbbbbbbbbbcccccccccc", "aaa", "aaa@wp.pl");

           // Assert
            Assert.IsTrue(validationResult.IsCorrect);
            Assert.AreEqual("", validationResult.ErrorMessage);
        }

        [Test]
        public void WhenFirstNameIsEmptyShouldReturnEmptyFieldErrorMessage()
        {
            // Act
            var validationResult = validator.Validate("", "aaa", "aaa@wp.pl");

            // Assert
            Assert.IsFalse(validationResult.IsCorrect);
            Assert.AreEqual("First Name cannot be empty", validationResult.ErrorMessage);
        }

        [Test]
        public void WhenFirstHasOnlySpacesShouldReturnEmptyFieldErrorMessage()
        {
            // Act
            var validationResult = validator.Validate("      ", "aaa", "aaa@wp.pl");

            // Assert
            Assert.IsFalse(validationResult.IsCorrect);
            Assert.AreEqual("First Name cannot be empty", validationResult.ErrorMessage);
        }

        [Test]
        public void WhenFirstNameHas31CharsShouldReturnToLongErrorMessage()
        {
            // Act
            var validationResult = validator.Validate("aaaaaaaaaabbbbbbbbbbcccccccccc1", "aaa", "aaa@wp.pl");

            // Assert
            Assert.IsFalse(validationResult.IsCorrect);
            Assert.AreEqual("First Name cannot be longer then 30 chars", validationResult.ErrorMessage);
        }

      
        [Test]
        public void WhenLastNameIsEmptyShouldReturnEmptyFieldErrorMessage()
        {
            // Act
            var validationResult = validator.Validate("aa", "", "aaa@wp.pl");

            // Assert
            Assert.IsFalse(validationResult.IsCorrect);
            Assert.AreEqual("Last Name cannot be empty", validationResult.ErrorMessage);
        }

        [Test]
        public void WhenLastNameHasOnlySpacesShouldReturnEmptyFieldErrorMessage()
        {
            // Act
            var validationResult = validator.Validate("aaa", "    ", "aaa@wp.pl");

            // Assert
            Assert.IsFalse(validationResult.IsCorrect);
            Assert.AreEqual("Last Name cannot be empty", validationResult.ErrorMessage);
        }
    }
}