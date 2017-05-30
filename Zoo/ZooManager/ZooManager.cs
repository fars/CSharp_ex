using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManager
{
    public class ZooManagerSingleton
    {
        public EventArgs data = null;

        public delegate void TickHandler(ZooManagerSingleton sender, EventArgs data);

        public event TickHandler TickEvent;

        private static readonly ZooManagerSingleton _instance = new ZooManagerSingleton();

        private ZooManagerSingleton()
        {
        }

        public static ZooManagerSingleton GetInstance()
        {
            return _instance;
        }

        public void StartWork()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);

                if (TickEvent != null)
                {
                    // Rise event
                    TickEvent(this, data);
                }
            }
        }

    }
}
