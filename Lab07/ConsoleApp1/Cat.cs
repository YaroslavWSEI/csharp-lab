﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : Mammal,IWalkable
    {
        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }
        public override string Sound => "Meow";
        public void ThrowOfTheTable()
        {
            Console.WriteLine("Throw of the table.");
        }
    }
}