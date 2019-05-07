using amicroservice.Models.Adapter;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestFahrenheitAdapter
    {
        FahrenheitAdapter fahrenheitAdapter = new FahrenheitAdapter();
        [Test]
        public void Given_NoArgument_When_CreatingFahrenheitAdapter_ReturnsFahrenheitAdapterObject()
        {
            Assert.NotNull(fahrenheitAdapter);
        }

        [Test]
        public void Given_TempInFahrenhei_When_Converting_Returns_TempIntCelsius()
        {
            Assert.True(fahrenheitAdapter.GetTemperature(2.2).Contains("2.2 in Celsius is 35.96"));
        }
    }
}