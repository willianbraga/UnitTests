using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSample.Domain;

namespace UnitTestSample
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        [TestCategory("Nova Sala)]
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
}
