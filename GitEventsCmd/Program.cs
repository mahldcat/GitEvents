using System;

namespace GitEventsCmd
{
    public class Program
    {
        public static string SomeAction(string arg)
        {
            return string.Format("Action:{0}",arg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
