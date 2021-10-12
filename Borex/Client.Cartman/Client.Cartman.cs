using Borexx;
using System;

namespace Borex
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new BorexServer();
            var rates = server.Rates;
            for (int i = 0; i < rates.Count; i++)
                Console.WriteLine("{0, 10}{1,8:0.00}{2,8:0.00}",
                    rates[i].Currency,
                    rates[i].Cost,
                    rates[i].Growth);
            Console.ReadKey();
        }
    }
}
