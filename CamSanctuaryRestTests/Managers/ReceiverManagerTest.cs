//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using CamSanctuaryRest.Managers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Permissions;
//using System.Text;
//using System.Threading.Tasks;
//using CamSanctuaryRest.Models;

//namespace CamSanctuaryRest.Managers.Tests
//{
//    [TestClass()]
//    public class ReceiverManagerTest
//    {
//        ReceiverManager manager = new ReceiverManager();
//        Files newFile = new Files() {Message = "Movement detected", DateTime = DateTime.Now};

//        [TestMethod]
//        public void TestGetAll()
//        {
//            int expectedResult = 5;
//            Assert.AreEqual(expectedResult, manager.GetAll().Count);
//        }

//        //[TestMethod]
//        //public void TestPost()
//        //{
//        //    manager.Post(newFile);
//        //    int expectedResult = 6;
//        //    Assert.AreEqual(expectedResult, manager.GetAll().Count);
//        //}


//    }
//}