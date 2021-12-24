using ConsoleDIBluprint.Messaging;
using ConsoleDIBluprint.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ConsoleDIBlueprint.Tests
{
    [TestClass]
    public class MainTests
    {
        [TestClass]
        public class ServicesTests
        {
            private readonly Mock<IContextMessages> _mockContextMessages = new();
            private readonly Mock<ICalculator> _mockCalculator = new();

            [TestMethod]
            [DataRow(2, 10, 12)]
            [DataRow(-20, 15, -5)]
            [DataRow(0, 0, 0)]
            public void When_CalculatorTwoIntNumbersAdded_Then_CorrectData(int a, int b, int realAnswer)
            {
                // Arrange
                var calculator = new Calculator(_mockContextMessages.Object);

                // Act
                var assumedAnswer = calculator.PutTwoIntNumbersTogether(a, b);

                // Assert
                Assert.AreEqual(realAnswer, assumedAnswer);
            }

            [TestMethod]
            [DataRow(2, 10, -8)]
            [DataRow(-20, 15, -35)]
            [DataRow(0, 0, 0)]
            public void When_CalculatorTwoIntNumbersSubtrackted_Then_CorrectData(int a, int b, int realAnswer)
            {
                // Arrange
                var calculator = new Calculator(_mockContextMessages.Object);

                // Act
                var assumedAnswer = calculator.SubtractTwoIntNumbers(a, b);

                // Assert
                Assert.AreEqual(realAnswer, assumedAnswer);
            }

            [TestMethod]
            [DataRow(2, 10, "add")]
            [DataRow(-20, 15, "add")]
            [DataRow(0, 0, "subtract")]
            public void When_BigBrainTwoIntNumbersOperatedOn_Then_ReturnTrue(int a, int b, string action)
            {
                // Arrange
                var bigBrain = new BigBrain(
                    _mockCalculator.Object,
                    _mockContextMessages.Object);
                bool realAnswer = true;

                // Act
                var assumedAnswer = bigBrain.InteractWithNumbers(a, b, action);

                // Assert
                Assert.AreEqual(realAnswer, assumedAnswer);
            }

            [TestMethod]
            [DataRow(2, 10, "hello")]
            [DataRow(-20, 15, " ")]
            [DataRow(0, 0, "---")]
            public void When_BigBrainTwoIntNumbersOperatedOnWithUnexistingImplementations_Then_ReturnFalse(int a, int b, string action)
            {
                // Arrange
                var bigBrain = new BigBrain(
                    _mockCalculator.Object,
                    _mockContextMessages.Object);
                bool realAnswer = false;

                // Act
                var assumedAnswer = bigBrain.InteractWithNumbers(a, b, action);

                // Assert
                Assert.AreEqual(realAnswer, assumedAnswer);
            }
        }
    }
}
