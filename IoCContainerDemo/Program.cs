﻿using Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Resolver resolver = new Resolver();
            var shopper = resolver.Resolve<Shopper>();
            
            shopper.Charge();

            Console.Read();
        }
    }
}