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
        private DateTime _startWorkingTime;
        private DateTime _endWorkingTime;

        private int _cagesNum = 0;
        private int _poolsNum = 0;

        private int _cagesCount = 0;
        private int _poolsCount = 0;

        private List<Cage> _cagesList = new List<Cage>();
        private List<Pool> _poolsList = new List<Pool>();

        private ZooManagerSingleton _zooManager = ZooManagerSingleton.GetInstance();

        public string zooAddress { get; set; }
        public string zooName { get; set; }

        public ZooPark()
        {
            zooAddress = "Kiev, Pobedy str., 7";
            zooName = "KievZoo";
            _cagesNum = 0;
            _poolsNum = 0;
    }

        public ZooPark(string name, string address, int cagesNum, int poolsNum)
        {
            if (name == null || address == null)
            {
                throw new ArgumentException("Name or adress is null");
            }

            zooAddress = address;
            zooName = name;
            _cagesNum = cagesNum;
            _poolsNum = poolsNum;
        }

        public void StartWork()
        {
            _zooManager.StartWork();
        }

        public ZooManagerSingleton GetManager()
        {
            return _zooManager;
        }


    }

}

