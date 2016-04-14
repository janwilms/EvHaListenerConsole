using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EvHaListenerConsole
{
    public class Counter
    {
        private static Counter _counter;
        private int _count = 0;

        public static Counter GetCounter()
        {
            if (_counter == null)
            {
                _counter = new Counter();
            }
            return _counter;
        }

        public void AddOne()
        {
            _count++;
        }

        public int getCount()
        {
            return _count;
        }
    }
}
