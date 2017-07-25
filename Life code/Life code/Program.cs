using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Life_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread a = new Thread(() => { Console.WriteLine("hahaha"); });
            a.Interrupt();
            a.Join();
            a.Resume();
            a.Start();
            a.Suspend();

            ThreadPool.
            
            
        }
    }
}
