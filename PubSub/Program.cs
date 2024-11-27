using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject<int> subject = new Subject<int>();
            Subscription<int> scription1 = subject.Subscribe(x => { Console.WriteLine($"收到 :{x}"); });
            Subscription<int> scription2 = subject.Subscribe(x => { Console.WriteLine($"收到2 :{x}"); });
            subject.Notify(1);
            subject.Notify(2);

            scription1.Unsubscribe();
            subject.Notify(3);
            Console.ReadKey();
        }
    }
}
