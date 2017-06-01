using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooManager;

namespace ZooManagerUnitTest
{
    [TestClass]
    public class ZooManagerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ZooManagerSingleton zooManager = ZooManagerSingleton.GetInstance();
            Assert.IsNotNull(zooManager);
        }
    }
}
