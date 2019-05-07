using amicroservice.Models.Builder;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestLaptopBuilder
    {
        private LaptopBuilder _laptopBuilder;
        private LaptopBuildDirector _laptopBuildDirector;
        public TestLaptopBuilder()
        {
            _laptopBuilder = new LaptopBuilder();
            _laptopBuildDirector = new LaptopBuildDirector(_laptopBuilder);
        }

        [Test]
        public void Given_NoArgument_When_CreatingLaptop_ReturnsLaptopObject()
        {
            _laptopBuildDirector.Construct();
            Computer newLaptop = _laptopBuilder.GetResult();
            Assert.NotNull(newLaptop);
            Assert.AreEqual(newLaptop.CPU, "LaptopCPU");
        }
    }
}