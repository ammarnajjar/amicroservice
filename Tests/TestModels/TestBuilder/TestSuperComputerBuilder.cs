using amicroservice.Models.Builder;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestSuperComputerBuilder
    {
        private SuperComputerBuilder _superComputerBuilder;
        private SuperComputerBuildDirector _superComputerBuildDirector;
        public TestSuperComputerBuilder()
        {
            _superComputerBuilder = new SuperComputerBuilder();
            _superComputerBuildDirector = new SuperComputerBuildDirector(_superComputerBuilder);
        }

        [Test]
        public void Given_NoArgument_When_CreatingSuperComputer_ReturnsSuperComputerObject()
        {
            _superComputerBuildDirector.Construct();
            Computer newSuperComputer = _superComputerBuilder.GetResult();
            Assert.NotNull(newSuperComputer);
            Assert.AreEqual(newSuperComputer.CPU, "SuperCPU");
        }
    }
}
