using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSelfHost;

namespace ConsoleHoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
            {
                WebApiSelfHost.MyService.Run();
            });
            Console.WriteLine("Run at " + MyService.BaseAddress);

            Console.ReadKey();
        }
    }
}
