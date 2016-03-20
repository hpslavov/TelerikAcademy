namespace _07.Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public delegate void RepeatDelegate(int timer);
    public class Timer
    {
        //Using delegates write a class Timer that can execute certain method at each t seconds.
        //task 7
        static void Main()
        {
            RepeatDelegate firstDelegate = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("{0}","@@@");
                }
            };
            firstDelegate(500);
        

        }
    }
}
