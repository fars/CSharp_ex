using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooManagerSingleton zooManager = ZooManagerSingleton.GetInstance();
        }

    }
}
