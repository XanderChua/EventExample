using System;
using System.Collections.Generic;
using System.Text;

namespace EventsExample
{
    class Publlisher
    {
        List<int> list = new List<int>();
        public event EventHandler dataAdded;

        public int this[int i]
        {
            get
            {
                return list[i];
            }
            set
            {
                list.Add(value);
                if (dataAdded != null)
                {
                    Console.WriteLine("Someone is interested in event");
                    dataAdded?.Invoke(this, null);
                }
                else
                {
                    Console.WriteLine("No one is interested in event");
                }
                
            }
        }
    }
}
