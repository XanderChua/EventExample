using System;
using System.Collections.Generic;
using System.Text;

namespace EventsExample
{
    class Subscriber
    {
        public Publlisher pub;

        public void SubscribeToEvent(Publlisher publisher)
        {
            pub = publisher;
            pub.dataAdded += Pub_dataAdded;
        }

        public void Pub_dataAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Data is subscribed into list");
        }

        public void unsubscribe()
        {
            pub.dataAdded -= Pub_dataAdded;
        }
    }
}
