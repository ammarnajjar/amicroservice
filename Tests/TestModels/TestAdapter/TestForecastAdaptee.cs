using amicroservice.Models.Adapter;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestForecastAdaptee
    {
        ForecastAdaptee forecastAdaptee = new ForecastAdaptee();

        [Test]
        public void Given_NoArgument_When_CreatingForecastAdapter_ReturnsForecastAdapterObject()
        {
            Assert.NotNull(forecastAdaptee);
        }

        [Test]
        public void Given_TempInDouble_When_Converting_Returns_TempAsString()
        {
            Assert.AreEqual(forecastAdaptee.GetTemperature(1.1), "1.1");
            Assert.AreEqual(forecastAdaptee.GetTemperature(2.0), "2");
            Assert.AreEqual(forecastAdaptee.GetTemperature(-3.0), "-3");
        }
    }
}