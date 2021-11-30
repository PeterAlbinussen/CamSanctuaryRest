using Microsoft.VisualStudio.TestTools.UnitTesting;
using CamSanctuaryRest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using CamSanctuaryRest.Models;

namespace CamSanctuaryRest.Managers.Tests
{
    [TestClass()]
    public class ReceiverManagerTest
    {
        public static int _nextId = 1;

        private static CamsanctuarydbContext context = new CamsanctuarydbContext();
        private ReceiverManager manager;

        private Message message = new Message() {Date = DateTime.Now, Id = _nextId++, Message1 = "motion detected"};

        public ReceiverManagerTest()
        {
            manager = new ReceiverManager(context);
        }
        
        [TestMethod]
        public void TestGetAll()
        {
            int expectedResult = 5;
            Assert.AreEqual(expectedResult, manager.GetAll().Count());
        }

        [TestMethod]
        public void TestPost()
        {
            manager.AddMessage(message);
            int expectedResult = 6;
            Assert.AreEqual(expectedResult, manager.GetAll().Count());
        }


    }
}