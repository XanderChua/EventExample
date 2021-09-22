using System;

namespace EventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            //add.addCompletedEventname += Add_addCompletedEventname;
            add.performAddEvent += Add_performAddEvent;
            add.addCompletedEventname += (res) => { Console.WriteLine("In anon method, Execution completed in addition class and result is: " + res); };
            add.eventExample += Add_eventExample;
            add.Add(3, 4);
            Console.ReadLine();

            Publlisher pub = new Publlisher();
            Subscriber sub = new Subscriber();

            sub.SubscribeToEvent(pub);
            pub[0] = 3;
            pub[1] = 5;
            sub.unsubscribe();
            pub[2] = 4;
        }

        private static void Add_addCompletedEventname(int res)
        {
            Console.WriteLine("Execution completed in addition class and result is: " + res);
        }
        private static void Add_performAddEvent(int a, int b)
        {
            Console.WriteLine("Execution completed in addition class and result is: " + (a + b));
        }

        private static void Add_eventExample(object sender, EventArgs e)
        {
            var parent = sender.GetType();
            Console.WriteLine($"Got event from {parent} class");
        }
    }
}
