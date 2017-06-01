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

        [TestMethod]
        public void TestZooParkConsructorNullArguments()
        {
            try
            {
                ZooPark zoo = new ZooPark(null, null, 0, 0);
            }
            catch (ArgumentException e)
            {
                Assert.AreSame(e.Message, "Name or adress is null");
                return;
            }

            Assert.Fail("No exception was throwed");
           
        }
    }
}
