using Microsoft.VisualStudio.TestTools.UnitTesting;
using CamSanctuaryRest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamSanctuaryRest.Models;

namespace CamSanctuaryRest.Managers.Tests
{
    [TestClass()]
    public class SenderManagerTests
    {
        private static CamsanctuarydbContext context = new CamsanctuarydbContext();
        private SenderManager manager;

        public SenderManagerTests()
        {
            manager = new SenderManager(context);
        }

        [TestMethod()]
        public void SenderGetAllTest()
        {
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, manager.GetAll().Count());
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            int expectedIDResult = 3;

            Assert.AreEqual(expectedIDResult, manager.GetById(3).Id);
        }

    }
}