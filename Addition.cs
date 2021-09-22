using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EventsExample
{
    public delegate void operation(int res);
    public delegate void operation1(int a, int b);
    class Addition
    {
        public event operation addCompletedEventname; //define event      
        public event operation1 performAddEvent;

        public event EventHandler eventExample;

        public void Add(int a,int b)
        {
            //long standing task
            Console.WriteLine("In Addition add: " + (a + b));
            raiseEvent(a + b);
            raiseEvent1(a,b);
        }

        public void raiseEvent1(int a, int b)
        {
            if (performAddEvent != null)
            {
                performAddEvent(a,b);
            }          
        }
        private void raiseEvent(int res)
        {
            //if(addCompletedEventname != null)
            //{
            //    addCompletedEventname(res);
            //}
            addCompletedEventname?.Invoke(res); //null propagation
        }

        private void raiseEvedntHandlerEvent()
        {
            eventExample?.Invoke(this, null);
        }
    }
}
