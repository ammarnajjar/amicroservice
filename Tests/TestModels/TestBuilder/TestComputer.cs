using amicroservice.Models.Builder;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestComputer
    {
        [Test]
        public void Given_NoArgument_When_CreatingComputer_ReturnsComputerObject()
        {
            Computer newComputer = new Computer("", "", "", "", "", "");
            Assert.NotNull(newComputer);
        }
    }
}

