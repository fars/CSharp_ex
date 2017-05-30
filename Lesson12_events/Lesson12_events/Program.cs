using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson12_events
{

    class SomeData : EventArgs
    {
        private DateTime _time;
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }

    public class Metronome
    {
        public EventArgs data = null;
        public delegate void TickHandler(Metronome sender, EventArgs data);

        public event TickHandler TickEvent;

        public void Start()
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

    public class Listener
    {
        private List<int> _countList = new List<int>();
        private Metronome _metronome = null;
        private static int _counter = 0;

        public Listener(Metronome met)
        {
            _metronome = met;
            _metronome.TickEvent += PeriodNotification;
        }

        public void PeriodNotification(Metronome metr, EventArgs data)
        {
            _counter++;
            _countList.Add(_counter);
            Console.WriteLine("{0} second down", _counter);
            if (_counter >= 11)
            {
                _metronome.TickEvent -= PeriodNotification;
                Console.WriteLine("Listening ends...");
            }
        }
    }

    public class ListenerTwo
    {
        public void Subscribe(Metronome met)
        {
            met.TickEvent += PeriodNotification;
        }

        public void PeriodNotification(Metronome metr, EventArgs data)
        {
            Console.WriteLine("Lisener2 get event and say hi...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Metronome met = new Metronome();
            Listener listener = new Listener(met);
            ListenerTwo lis2 = new ListenerTwo();
            lis2.Subscribe(met);
            met.Start();
        }
    }
}
