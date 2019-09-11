using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.API.Tests
{
    using FizzBuzz.API.Services;

    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(11, "11")]
        public void GivenWhenNumberDivisibleBy3ReturnFizz(int inputNumber, string expectedResponse)
        {
            // Arrange
            var service = new FizzBuzzService();

            // Act
            var response = service.GetFizzBuz(inputNumber);

            //Assert
            Assert.AreEqual(expectedResponse, response);
        }
    }
}