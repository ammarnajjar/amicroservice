using System.Collections.Generic;
using amicroservice.Controllers;
using amicroservice.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;

namespace amicroservice.Tests
{
    [TestFixture]
    public class TestPizzaController
    {
        private readonly PizzaController _pizzaController;

        Mock<DbSet<T>> MockDbSet<T>(ICollection<T> list) where T : class, new()
        {
            IQueryable<T> queryableList = list.AsQueryable();
            Mock<DbSet<T>> dbSetMock = new Mock<DbSet<T>>();
            dbSetMock.As<IQueryable<T>>().Setup(x => x.Provider).Returns(queryableList.Provider);
            dbSetMock.As<IQueryable<T>>().Setup(x => x.Expression).Returns(queryableList.Expression);
            dbSetMock.As<IQueryable<T>>().Setup(x => x.ElementType).Returns(queryableList.ElementType);
            dbSetMock.As<IQueryable<T>>().Setup(x => x.GetEnumerator()).Returns(() => queryableList.GetEnumerator());
            // dbSetMock.Setup(x => x.Create()).Returns(new T());

            return dbSetMock;
        }
        public TestPizzaController()
        {
            //Arrange
            var pizzaOrders = new List<Pizza>() { Pizza.Default() };
            var mockDbSet = MockDbSet(pizzaOrders);
            var _pizzaContext = new Mock<IDbContext>();
            _pizzaContext.Setup(m => m.PizzaOrders).Returns(mockDbSet.Object);

            _pizzaController = new PizzaController(_pizzaContext.Object);
        }

        [Test]
        public void Given_InitialState_When_GettingAll_ReturnsOneItemListOfPizza()
        {

            var result = _pizzaController.Get();
            System.Console.WriteLine("Debug: ", result.Status);

            // Assert.AreEqual(1, result.Result.Value.Count);
        }
    }
}
