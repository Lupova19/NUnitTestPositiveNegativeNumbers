using PositiveNegativeNumbers;

namespace NUnitTestPositiveNegativeNumbers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4)]
        [TestCase(2222225)]
        [TestCase(10.11111111111111112545)]
        [TestCase(7974154.12)]
        [TestCase(1000.233545)]
        [TestCase(11000000000000.5451)]
        public void TestIsPositiveReturnsTrue(double number)
        {
            // Arrange
            Numbers nums = new Numbers();

            // Act
            bool result = nums.IsPositive(number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(-3)]
        [TestCase(-19)]
        [TestCase(-2219)]
        [TestCase(-31548787.21154)]
        [TestCase(-71685511.12)]
        public void TestNegativeNumberReturnsFalse(double number)
        {
            // Arrange

            Numbers nums = new Numbers();

            // Act
            bool result = nums.IsPositive(number);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TestThrowArgumentException()
        {
            //Arrange
            double number = 0;
            Numbers nums = new Numbers();

            //Assert
            Assert.Throws<ArgumentException>(() => nums.IsPositive(number), "Не може да е 0!!!");
        }
    }
}