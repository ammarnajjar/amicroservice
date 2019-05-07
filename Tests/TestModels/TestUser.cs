using amicroservice.Models;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestUser
    {
        [Test]
        public void Given_NoArgument_When_CreatingUser_ReturnsUserObject()
        {
            User newUser = new User();
            Assert.NotNull(newUser);
        }
    }
}
