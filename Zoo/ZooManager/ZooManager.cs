using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManager
{
    public class ZooManagerSingleton
    {
        private static readonly ZooManagerSingleton _instance = new ZooManagerSingleton();

        private ZooManagerSingleton()
        {
        }

        public static ZooManagerSingleton GetInstance()
        {
            return _instance;
        }
    }
}
