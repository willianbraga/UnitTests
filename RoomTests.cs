using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSample.Domain;
using UnitTestSample.Domain.Contracts;
using UnitTestSample.FakeRepository;

namespace UnitTestSample
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        [TestCategory("Nova Sala")]
        public void TheRoomNameMustBeSala1()
        {
            var room = new Room("Sala 1");

            Assert.AreEqual("Sala 1", room.Name);
        }

        [TestMethod]
        [TestCategory("Nova Sala")]
        [ExpectedException(typeof(Exception))]
        public void TheNameMustBeInformed()
        {
            var room = new Room("");
        }
    }

    [TestClass]
    public class GivenANewRoom
    {
        [TestMethod]
        [TestCategory("Reserva de Sala")]
        [ExpectedException(typeof(Exception))]

        public void ARoomMustBeAvailable()
        {
            var startDate = DateTime.Now.AddHours(1);
            var endDate = DateTime.Now.AddHours(3);
            IBookRepository rep = new BookFakeRepository();
            var room = new Room("Sala 1");

            room.Book(startDate,
                    endDate,
                    rep.GetByDate(startDate, endDate));
        }
        [TestMethod]
        [TestCategory("Reserva de Sala")]
        public void ARoomMustBeReserved()
        {
            var startDate = DateTime.Now.AddHours(1);
            var endDate = DateTime.Now.AddHours(3);
            IBookRepository rep = new BookFakeRepository();
            var room = new Room("Sala 1");

            room.Book(startDate,
                    endDate,
                    new List<DateTime>());
        }
    }
}
