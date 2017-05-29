using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    public class ZooPark
    {
        private int _zooAquariumCapacity = 0;
        private int _zooCagesCapacity = 0;

        private ZooManagerSingleton _zooManager = ZooManagerSingleton.GetInstance();

        public string zooAddress { get; set; }
        public string zooName { get; set; }

        public ZooPark()
        {
            zooAddress = "Kiev, Pobedy str., 7";
            zooName = "KievZoo";
        }

        public ZooPark(string name, string address, int cageNum, int aquariumNum)
        {

        }
    }
}

