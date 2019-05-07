using amicroservice.Models.Factory;
using NUnit.Framework;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestPizza
    {
        [Test]
        public void Given_NoArgument_When_CreatingPizza_ReturnsPizzaObject()
        {
            Pizza newPizza = new Pizza();
            Assert.NotNull(newPizza);
        }

        [Test]
        public void Given_Default_When_CreatingPizza_ReturnsMargheritaPizza()
        {
            Pizza newPizza = Pizza.Default();
            Assert.AreEqual(newPizza.Name, "Margherita");
        }

        [Test]
        public void Given_Margherita_When_CreatingPizza_ReturnsMargheritaPizza()
        {
            Pizza newPizza = Pizza.MargheritaPizza();
            Assert.AreEqual(newPizza.Name, "Margherita");
        }

        [Test]
        public void Given_Salami_When_CreatingPizza_ReturnsMargheritaPizza()
        {
            Pizza newPizza = Pizza.SalamiPizza();
            Assert.AreEqual(newPizza.Name, "Salami");
        }
    }
}
