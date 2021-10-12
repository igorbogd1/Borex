﻿using Borexx;
using System;

namespace Borex
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new BorexServer();
            foreach (var e in server.Rates)
            Console.WriteLine("{0, 10}{1,8:0.00}{2,8:0.00}",
                    e.Currency,
                    e.Cost,
                    e.Growth);

            Console.ReadKey();
        }
    }
}
