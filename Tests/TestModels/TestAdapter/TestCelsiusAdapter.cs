using amicroservice.Models.Adapter;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestCelsiusAdapter
    {
        CelsiusAdapter celsiusAdapter = new CelsiusAdapter();
        [Test]
        public void Given_NoArgument_When_CreatingCelsiusAdapter_ReturnsCelsiusAdapterObject()
        {
            Assert.NotNull(celsiusAdapter);
        }

        [Test]
        public void Given_TempInCelsius_When_Converting_Returns_TempInFahrenheit()
        {
            Assert.True(celsiusAdapter.GetTemperature(2.2).Contains("2.2 in Fahrenheit is -16.555"));
        }
    }
}