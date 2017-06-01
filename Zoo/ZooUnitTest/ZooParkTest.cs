using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo;

namespace ZooUnitTest
{
    [TestClass]
    public class ZooParkTest
    {
        [TestMethod]
        public void TestZooParkConsructor()
        {
            ZooPark zoo = new ZooPark();
            Assert.AreSame(zoo.zooName, "KievZoo");
        }
    }
}
